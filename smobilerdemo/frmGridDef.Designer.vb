Imports Smobiler.Core
Partial Public Class frmGridDef
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
        Me.Label2 = New Smobiler.Core.Controls.Label()
        '
        'Label1
        '
        Me.Label1.FontSize = 5.0R
        Me.Label1.Location = New Smobiler.Core.PointS(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "¿Í»§±àºÅ"
        '
        'Label2
        '
        Me.Label2.DataMember = "CUST_ID"
        Me.Label2.DisplayMember = "CUST_ID"
        Me.Label2.FontSize = 5.0R
        Me.Label2.Location = New Smobiler.Core.PointS(31, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 3
        '
        'frmGridDef
        '
        Me.Controls.AddRange(New Smobiler.Core.Controls.MobileControl() {Me.Label1, Me.Label2})
        Me.Size = New System.Drawing.Size(120, 20)

    End Sub
    Friend WithEvents Label1 As Smobiler.Core.Controls.Label
    Friend WithEvents Label2 As Smobiler.Core.Controls.Label

#End Region

End Class
