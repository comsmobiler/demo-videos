Imports Smobiler.Core
Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows.Forms

Public Class frmCreate
    Inherits Smobiler.Core.MobileForm

    'toolbar事件触发时逻辑
    Private Sub frmCreate_ToolbarItemClick(sender As Object, e As ToolbarClickEventArgs) Handles Me.ToolbarItemClick
        Try
            '选择触发的事件名称
            Select Case e.Name
                '保存事件
                Case Save.Name
                    If txtNO.Text.Trim.Length <= 0 Then Throw New Exception("请输入客户编号。")
                    If txtName.Text.Trim.Length <= 0 Then Throw New Exception("请输入客户描述。")
                    Dim co As New OleDbConnection
                    co.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\smobilerdemo.accdb;Persist Security Info=True"
                    co.Open()
                    Dim myCommand As New OleDbCommand("insert into tblCustomer(CUST_ID,CUST_NAME,INV_CONTENT)values(@CUST_ID,@CUST_NAME,@INV_CONTENT)", co)
                    myCommand.Parameters.Add(New OleDbParameter("@CUST_ID", OleDbType.BSTR, 10))
                    myCommand.Parameters("@CUST_ID").Value = txtNO.Text

                    myCommand.Parameters.Add(New OleDbParameter("@CUST_NAME", OleDbType.BSTR, 50))
                    myCommand.Parameters("@CUST_NAME").Value = txtName.Text

                    myCommand.Parameters.Add(New OleDbParameter("@INV_CONTENT", OleDbType.BSTR, 255))
                    myCommand.Parameters("@INV_CONTENT").Value = txtContact.Text
                    Dim retint As Integer = myCommand.ExecuteNonQuery()
                    myCommand.Connection.Close()
                    If retint > 0 Then MessageBox.Show("新增成功！")
                    co.Close()
                    '返回事件
                Case Back.Name
                    ' 关闭当前窗体
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
