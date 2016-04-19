Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports Smobiler.Utility.Encoding
Imports System.Windows.Forms

Public Class frmMain
    ''' <summary>
    ''' 网卡字典
    ''' </summary>
    ''' <remarks></remarks>
    Dim networkDict As New Dictionary(Of String, String)
    ''' <summary>
    ''' Smobiler服务
    ''' </summary>
    ''' <remarks></remarks>
    Dim server As Smobiler.Core.MobileServer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InitialNetworkInterfaces()
            '定义Smobiler服务
            server = New Smobiler.Core.MobileServer
            '设置默认网卡
            If networkDict.Count > 0 Then
                Me.combNets.Items.AddRange(networkDict.Keys.ToArray)
                Me.combNets.SelectedIndex = 0
            End If
            '启动Smobiler服务
            StartServer()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
    End Sub

    ''' <summary>
    ''' 获取当前可用的网卡信息
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitialNetworkInterfaces()
        Dim i As Integer = 1
        Dim NetworkInterfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        For Each NetworkIntf As NetworkInterface In NetworkInterfaces
            If NetworkIntf.OperationalStatus = OperationalStatus.Up AndAlso NetworkIntf.NetworkInterfaceType <> NetworkInterfaceType.Loopback Then
                Dim IPInterfaceProperties As IPInterfaceProperties = NetworkIntf.GetIPProperties()
                Dim UnicastIPAddressInformationCollection As UnicastIPAddressInformationCollection = IPInterfaceProperties.UnicastAddresses
                For Each UnicastIPAddressInformation As UnicastIPAddressInformation In UnicastIPAddressInformationCollection
                    If UnicastIPAddressInformation.Address.AddressFamily = AddressFamily.InterNetwork Then
                        networkDict.Add(i.ToString + ":" + NetworkIntf.Name + "/" + NetworkIntf.Description, UnicastIPAddressInformation.Address.ToString())
                        i += 1
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub StartServer()
        Try
            '服务起始界面
            server.StartUpForm = GetType(frmMenu)
            '服务TCP端口，默认为2323   
            Me.txtTcpPort.Text = server.Setting.TcpServerPort.ToString()
            '服务HTTP端口，默认为2324  
            Me.txtHTTPPort.Text = server.Setting.HttpServerPort.ToString()
            '启用服务
            server.StartServer()
        Catch ex As System.Net.HttpListenerException
            '遇到HTTP监听无法添加的异常时，需要注册HTTP监听，一般原因是由于当前用户没有管理员权限
            Dim psi As New ProcessStartInfo("netsh", "http delete urlacl url=http://+:" + server.Setting.HttpServerPort.ToString() + "/")
            psi.Verb = "runas"
            psi.CreateNoWindow = True
            psi.WindowStyle = ProcessWindowStyle.Hidden
            psi.UseShellExecute = True
            Process.Start(psi).WaitForExit()
            psi = New ProcessStartInfo("netsh", "http add urlacl url=http://+:" + server.Setting.HttpServerPort.ToString() + "/ user=" + Environment.UserDomainName + "\" + Environment.UserName)
            psi.Verb = "runas"
            psi.CreateNoWindow = True
            psi.WindowStyle = ProcessWindowStyle.Hidden
            psi.UseShellExecute = True
            Process.Start(psi).WaitForExit()
            server.StartServer()
        End Try
    End Sub

    ''' <summary>
    ''' 在下拉框选择变更事件重新生成二维码
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub combNets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combNets.SelectedIndexChanged
        If networkDict.Count > 0 Then
            Me.txtNetAddress.Text = networkDict.Item(Me.combNets.SelectedItem)
            qrcodeControl.SetServerInfo(Me.txtNetAddress.Text, server.Setting.TcpServerPort, server.Setting.HttpServerPort)
        End If
    End Sub

    ''' <summary>
    ''' 打开设置界面
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Try
            Dim setting As New frmSetting()
            If setting.ShowDialog() = DialogResult.Yes Then
                server.StopServer()
                server.Setting.InitialData()
                StartServer()
                qrcodeControl.SetServerInfo(Me.txtNetAddress.Text, server.Setting.TcpServerPort, server.Setting.HttpServerPort)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.[Exit]()
        End Try
    End Sub
End Class
