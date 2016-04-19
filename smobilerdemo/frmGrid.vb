Imports Smobiler.Core
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmGrid
    Inherits Smobiler.Core.MobileForm

    Dim PageSize As Integer = 10
    Dim RecordCount As Integer = 0
    Dim PageCount As Integer = 0
    Dim CurrentPage As Integer = 0
    Dim startindex As Integer = 0
    Dim pageindex As Integer = 0
    Private Sub frmGrid_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim co As New OleDbConnection
            co.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\smobilerdemo.accdb;Persist Security Info=True"
            co.Open()
            Dim cmd As String = "select * from tblCustomer"

            Dim dataset As New DataSet
            Dim adapter As New OleDbDataAdapter(cmd, co)
            adapter.Fill(dataset, "tblCustomer")
            '总记录数
            RecordCount = dataset.Tables("tblCustomer").Rows.Count
            '总页数
            If RecordCount > 0 Then
                If (RecordCount Mod PageSize) <> 0 Then
                    PageCount = RecordCount \ PageSize + 1
                Else
                    PageCount = RecordCount \ PageSize
                End If

            End If
            Me.GridView1.DataSource = dataset
            Me.GridView1.DataBind()
            co.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub GridView1_DownSlippling(sender As Object, e As EventArgs) Handles GridView1.DownSlippling
        'Try
        '    MessageBox.Show(e.GetHashCode())
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub GridView1_UpSlippling(sender As Object, e As EventArgs) Handles GridView1.UpSlippling
        'Try
        '    MessageBox.Show("1" + e.GetHashCode())
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub frmGrid_ToolbarItemClick(sender As Object, e As ToolbarClickEventArgs) Handles MyBase.ToolbarItemClick
        If e.Name = tExit.Name Then
            Me.Close()
        End If

    End Sub
End Class
