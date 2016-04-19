<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            If disposing AndAlso server IsNot Nothing Then
                server.StopServer()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.labNets = New System.Windows.Forms.Label()
        Me.combNets = New System.Windows.Forms.ComboBox()
        Me.txtNetAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.txtHTTPPort = New System.Windows.Forms.TextBox()
        Me.txtTcpPort = New System.Windows.Forms.TextBox()
        Me.labHTTPPort = New System.Windows.Forms.Label()
        Me.labTCPPort = New System.Windows.Forms.Label()
        Me.qrcodeControl = New Smobiler.Utility.Encoding.Windows.Forms.QrCodeImgControl()
        CType(Me.qrcodeControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labNets
        '
        Me.labNets.AutoSize = True
        Me.labNets.Location = New System.Drawing.Point(19, 14)
        Me.labNets.Name = "labNets"
        Me.labNets.Size = New System.Drawing.Size(53, 12)
        Me.labNets.TabIndex = 2
        Me.labNets.Text = "选择网卡"
        '
        'combNets
        '
        Me.combNets.BackColor = System.Drawing.Color.White
        Me.combNets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combNets.FormattingEnabled = True
        Me.combNets.Location = New System.Drawing.Point(90, 11)
        Me.combNets.Name = "combNets"
        Me.combNets.Size = New System.Drawing.Size(237, 20)
        Me.combNets.TabIndex = 3
        '
        'txtNetAddress
        '
        Me.txtNetAddress.BackColor = System.Drawing.Color.White
        Me.txtNetAddress.Location = New System.Drawing.Point(90, 37)
        Me.txtNetAddress.Name = "txtNetAddress"
        Me.txtNetAddress.ReadOnly = True
        Me.txtNetAddress.Size = New System.Drawing.Size(237, 21)
        Me.txtNetAddress.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "服务器地址"
        '
        'txtInfo
        '
        Me.txtInfo.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtInfo.Location = New System.Drawing.Point(354, 10)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(389, 396)
        Me.txtInfo.TabIndex = 5
        Me.txtInfo.Text = resources.GetString("txtInfo.Text")
        '
        'btnSetting
        '
        Me.btnSetting.Location = New System.Drawing.Point(21, 91)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(306, 23)
        Me.btnSetting.TabIndex = 11
        Me.btnSetting.Text = "更多设置"
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'txtHTTPPort
        '
        Me.txtHTTPPort.BackColor = System.Drawing.Color.White
        Me.txtHTTPPort.Location = New System.Drawing.Point(251, 64)
        Me.txtHTTPPort.Name = "txtHTTPPort"
        Me.txtHTTPPort.ReadOnly = True
        Me.txtHTTPPort.Size = New System.Drawing.Size(76, 21)
        Me.txtHTTPPort.TabIndex = 9
        '
        'txtTcpPort
        '
        Me.txtTcpPort.BackColor = System.Drawing.Color.White
        Me.txtTcpPort.Location = New System.Drawing.Point(90, 64)
        Me.txtTcpPort.Name = "txtTcpPort"
        Me.txtTcpPort.ReadOnly = True
        Me.txtTcpPort.Size = New System.Drawing.Size(76, 21)
        Me.txtTcpPort.TabIndex = 10
        '
        'labHTTPPort
        '
        Me.labHTTPPort.AutoSize = True
        Me.labHTTPPort.Location = New System.Drawing.Point(192, 68)
        Me.labHTTPPort.Name = "labHTTPPort"
        Me.labHTTPPort.Size = New System.Drawing.Size(53, 12)
        Me.labHTTPPort.TabIndex = 7
        Me.labHTTPPort.Text = "HTTP端口"
        '
        'labTCPPort
        '
        Me.labTCPPort.AutoSize = True
        Me.labTCPPort.Location = New System.Drawing.Point(19, 68)
        Me.labTCPPort.Name = "labTCPPort"
        Me.labTCPPort.Size = New System.Drawing.Size(47, 12)
        Me.labTCPPort.TabIndex = 8
        Me.labTCPPort.Text = "TCP端口"
        '
        'qrcodeControl
        '
        Me.qrcodeControl.ErrorCorrectLevel = Smobiler.Utility.Encoding.ErrorCorrectionLevel.M
        Me.qrcodeControl.Image = CType(resources.GetObject("qrcodeControl.Image"), System.Drawing.Image)
        Me.qrcodeControl.Location = New System.Drawing.Point(21, 130)
        Me.qrcodeControl.Name = "qrcodeControl"
        Me.qrcodeControl.QuietZoneModule = Smobiler.Utility.Encoding.Windows.Render.QuietZoneModules.Two
        Me.qrcodeControl.Size = New System.Drawing.Size(306, 276)
        Me.qrcodeControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.qrcodeControl.TabIndex = 7
        Me.qrcodeControl.TabStop = False
        Me.qrcodeControl.Text = "smobiler"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(755, 418)
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.txtHTTPPort)
        Me.Controls.Add(Me.txtTcpPort)
        Me.Controls.Add(Me.labHTTPPort)
        Me.Controls.Add(Me.labTCPPort)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.txtNetAddress)
        Me.Controls.Add(Me.combNets)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labNets)
        Me.Controls.Add(Me.qrcodeControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smobiler Launcher"
        CType(Me.qrcodeControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labNets As System.Windows.Forms.Label
    Friend WithEvents combNets As System.Windows.Forms.ComboBox
    Friend WithEvents txtNetAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Private WithEvents btnSetting As System.Windows.Forms.Button
    Friend WithEvents txtHTTPPort As System.Windows.Forms.TextBox
    Friend WithEvents txtTcpPort As System.Windows.Forms.TextBox
    Friend WithEvents labHTTPPort As System.Windows.Forms.Label
    Friend WithEvents labTCPPort As System.Windows.Forms.Label
    Friend WithEvents qrcodeControl As New Smobiler.Utility.Encoding.Windows.Forms.QrCodeImgControl()

End Class
