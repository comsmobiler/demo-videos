Imports Smobiler.Core
Public Class frmMenu
    Inherits Smobiler.Core.MobileForm


    Private Sub btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Create.Click
        Try
            Dim frmcreate1 As New frmCreate() : Me.Redirect(frmcreate1)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim frm As New frmGrid() : Me.Redirect(frm)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
