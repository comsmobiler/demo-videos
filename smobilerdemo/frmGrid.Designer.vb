Imports Smobiler.Core
Partial Public Class frmGrid
    Inherits Smobiler.Core.MobileForm

#Region "SmobilerForm Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the SmobilerForm Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'VTForm overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub


    'NOTE: The following procedure is required by the SmobilerForm Designer
    'It can be modified using the SmobilerForm Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GridView1 = New Smobiler.Core.Controls.GridView()
        Me.tExit = New Smobiler.Core.Controls.ToolbarItem()
        '
        'GridView1
        '
        Me.GridView1.AllowSlip = True
        Me.GridView1.AutoHeight = True
        Me.GridView1.CausesValidation = True
        Me.GridView1.Layout = "frmGridDef"
        Me.GridView1.Location = New Smobiler.Core.PointS(0.0!, 2.0!)
        Me.GridView1.Name = "GridView1"
        Me.GridView1.Size = New System.Drawing.SizeF(120.0!, 180.0!)
        Me.GridView1.TabIndex = 2
        '
        'tExit
        '
        Me.tExit.IconID = "Exit"
        Me.tExit.Name = "tExit"
        Me.tExit.Text = "返回"
        '
        'frmGrid
        '
        Me.Controls.AddRange(New Smobiler.Core.Controls.MobileControl() {Me.GridView1})
        Me.TitleText = "查看客户"
        Me.Toolbar.AddRange(New Smobiler.Core.Controls.ToolbarItem() {Me.tExit})

    End Sub
    Friend WithEvents GridView1 As Smobiler.Core.Controls.GridView
    Friend WithEvents tExit As Smobiler.Core.Controls.ToolbarItem

#End Region

End Class
