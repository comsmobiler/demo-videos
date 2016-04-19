Imports Smobiler.Core
Partial Public Class frmMenu
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
        Me.Label1 = New Smobiler.Core.Controls.Label()
        Me.Line1 = New Smobiler.Core.Controls.Line()
        Me.Image1 = New Smobiler.Core.Controls.Image()
        Me.Label2 = New Smobiler.Core.Controls.Label()
        Me.Button1 = New Smobiler.Core.Controls.Button()
        Me.btn_Create = New Smobiler.Core.Controls.Button()
        Me.Line2 = New Smobiler.Core.Controls.Line()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.FontSize = 6.0!
        Me.Label1.Location = New Smobiler.Core.PointS(0.0!, 2.0!)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.SizeF(120.0!, 10.0!)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "客户/联系人管理"
        '
        'Line1
        '
        Me.Line1.FontSize = 1.0!
        Me.Line1.ForeColor = System.Drawing.Color.Empty
        Me.Line1.Location = New Smobiler.Core.PointS(0.0!, 13.0!)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.SizeF(120.0!, 1.0!)
        Me.Line1.TabIndex = 3
        '
        'Image1
        '
        Me.Image1.ResourceID = "lianxiren2"
        Me.Image1.Location = New Smobiler.Core.PointS(2.0!, 14.0!)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.SizeF(12.0!, 10.0!)
        Me.Image1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.FontSize = 5.0!
        Me.Label2.Location = New Smobiler.Core.PointS(16.0!, 13.0!)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.SizeF(82.0!, 12.0!)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "客户管理"
        '
        'Button1
        '
        Me.Button1.FontSize = 5.0!
        Me.Button1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center
        Me.Button1.Location = New Smobiler.Core.PointS(98.0!, 13.0!)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.SizeF(10.0!, 12.0!)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = ">"
        '
        'btn_Create
        '
        Me.btn_Create.FontSize = 5.0!
        Me.btn_Create.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center
        Me.btn_Create.Location = New Smobiler.Core.PointS(108.0!, 13.0!)
        Me.btn_Create.Name = "btn_Create"
        Me.btn_Create.Size = New System.Drawing.SizeF(10.0!, 12.0!)
        Me.btn_Create.TabIndex = 7
        Me.btn_Create.Text = "+"
        '
        'Line2
        '
        Me.Line2.FontSize = 1.0!
        Me.Line2.ForeColor = System.Drawing.Color.Empty
        Me.Line2.Location = New Smobiler.Core.PointS(0.0!, 25.0!)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.SizeF(120.0!, 1.0!)
        Me.Line2.TabIndex = 8
        '
        'frmMenu
        '
        Me.Controls.AddRange(New Smobiler.Core.Controls.MobileControl() {Me.Label1, Me.Line1, Me.Image1, Me.Label2, Me.Button1, Me.btn_Create, Me.Line2})
        Me.TitleText = "菜单"

    End Sub
    Friend WithEvents Label1 As Smobiler.Core.Controls.Label
    Friend WithEvents Line1 As Smobiler.Core.Controls.Line
    Friend WithEvents Image1 As Smobiler.Core.Controls.Image
    Friend WithEvents Label2 As Smobiler.Core.Controls.Label
    Friend WithEvents Button1 As Smobiler.Core.Controls.Button
    Friend WithEvents btn_Create As Smobiler.Core.Controls.Button
    Friend WithEvents Line2 As Smobiler.Core.Controls.Line

#End Region

End Class
