Imports System.Windows.Forms

Public Class frmSetting
    Private mSetting As Smobiler.Core.Setting = Nothing

    Public Sub New()
        InitializeComponent()
        mSetting = New Smobiler.Core.Setting
    End Sub

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.gridMain.SelectedObject = mSetting
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            mSetting.SaveData()
            If MessageBox.Show("保存成功，是否重新启动服务", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Me.DialogResult = DialogResult.Yes
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class