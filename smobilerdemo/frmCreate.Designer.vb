Imports Smobiler.Core
Partial Public Class frmCreate
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
        Me.txtNO = New Smobiler.Core.Controls.TextBox()
        Me.Label2 = New Smobiler.Core.Controls.Label()
        Me.txtName = New Smobiler.Core.Controls.TextBox()
        Me.Label3 = New Smobiler.Core.Controls.Label()
        Me.txtContact = New Smobiler.Core.Controls.TextBox()
        Me.Label4 = New Smobiler.Core.Controls.Label()
        Me.txtAdress = New Smobiler.Core.Controls.TextBox()
        Me.txtNote = New Smobiler.Core.Controls.TextBox()
        Me.Save = New Smobiler.Core.Controls.ToolbarItem()
        Me.Back = New Smobiler.Core.Controls.ToolbarItem()
        '
        'Label1
        '
        Me.Label1.Border = New Smobiler.Core.Border(1, 1, 0, 1)
        Me.Label1.BorderColor = System.Drawing.Color.Gray
        Me.Label1.FontSize = 5.0!
        Me.Label1.Location = New Smobiler.Core.PointS(2.0!, 1.0!)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New Smobiler.Core.Padding(2.0!, 0.0!, 0.0!, 0.0!)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "客户编号"
        '
        'txtNO
        '
        Me.txtNO.Border = New Smobiler.Core.Border(1)
        Me.txtNO.BorderColor = System.Drawing.Color.Gray
        Me.txtNO.FontSize = 5.0!
        Me.txtNO.ForeColor = System.Drawing.Color.Gray
        Me.txtNO.Location = New Smobiler.Core.PointS(32.0!, 1.0!)
        Me.txtNO.Name = "txtNO"
        Me.txtNO.Padding = New Smobiler.Core.Padding(2.0!, 0.0!, 0.0!, 0.0!)
        Me.txtNO.Size = New System.Drawing.SizeF(86.0!, 10.0!)
        Me.txtNO.TabIndex = 3
        Me.txtNO.WaterMarkText = "(必填)"
        '
        'Label2
        '
        Me.Label2.Border = New Smobiler.Core.Border(1, 1, 0, 1)
        Me.Label2.BorderColor = System.Drawing.Color.Gray
        Me.Label2.FontSize = 5.0!
        Me.Label2.Location = New Smobiler.Core.PointS(2.0!, 14.0!)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New Smobiler.Core.Padding(2.0!, 0.0!, 0.0!, 0.0!)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "客户名称"
        '
        'txtName
        '
        Me.txtName.Border = New Smobiler.Core.Border(1)
        Me.txtName.BorderColor = System.Drawing.Color.Gray
        Me.txtName.FontSize = 5.0!
        Me.txtName.ForeColor = System.Drawing.Color.Gray
        Me.txtName.Location = New Smobiler.Core.PointS(32.0!, 14.0!)
        Me.txtName.Name = "txtName"
        Me.txtName.Padding = New Smobiler.Core.Padding(2.0!, 0.0!, 0.0!, 0.0!)
        Me.txtName.Size = New System.Drawing.SizeF(86.0!, 10.0!)
        Me.txtName.TabIndex = 5
        Me.txtName.WaterMarkText = "(必填)"
        '
        'Label3
        '
        Me.Label3.Border = New Smobiler.Core.Border(1, 1, 0, 1)
        Me.Label3.BorderColor = System.Drawing.Color.Gray
        Me.Label3.FontSize = 5.0!
        Me.Label3.Location = New Smobiler.Core.PointS(2.0!, 28.0!)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New Smobiler.Core.Padding(2.0!, 0.0!, 0.0!, 0.0!)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "联系人"
        '
        'txtContact
        '
        Me.txtContact.Border = New Smobiler.Core.Border(1)
        Me.txtContact.BorderColor = System.Drawing.Color.Gray
        Me.txtContact.FontSize = 5.0!
        Me.txtContact.ForeColor = System.Drawing.Color.Gray
        Me.txtContact.Location = New Smobiler.Core.PointS(32.0!, 28.0!)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Padding = New Smobiler.Core.Padding(2.0!, 0.0!, 0.0!, 0.0!)
        Me.txtContact.Size = New System.Drawing.SizeF(86.0!, 10.0!)
        Me.txtContact.TabIndex = 7
        Me.txtContact.WaterMarkText = "(必填)"
        '
        'Label4
        '
        Me.Label4.Border = New Smobiler.Core.Border(1, 1, 0, 1)
        Me.Label4.BorderColor = System.Drawing.Color.Gray
        Me.Label4.FontSize = 5.0!
        Me.Label4.Location = New Smobiler.Core.PointS(2.0!, 41.0!)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New Smobiler.Core.Padding(2.0!, 0.0!, 0.0!, 0.0!)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "地址"
        '
        'txtAdress
        '
        Me.txtAdress.Border = New Smobiler.Core.Border(1)
        Me.txtAdress.BorderColor = System.Drawing.Color.Gray
        Me.txtAdress.FontSize = 5.0!
        Me.txtAdress.ForeColor = System.Drawing.Color.Gray
        Me.txtAdress.Location = New Smobiler.Core.PointS(32.0!, 41.0!)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Padding = New Smobiler.Core.Padding(2.0!, 0.0!, 0.0!, 0.0!)
        Me.txtAdress.Size = New System.Drawing.SizeF(86.0!, 10.0!)
        Me.txtAdress.TabIndex = 9
        Me.txtAdress.WaterMarkText = "(地址填写)"
        '
        'txtNote
        '
        Me.txtNote.Border = New Smobiler.Core.Border(1)
        Me.txtNote.BorderColor = System.Drawing.Color.Gray
        Me.txtNote.FontSize = 5.0!
        Me.txtNote.ForeColor = System.Drawing.Color.Gray
        Me.txtNote.Location = New Smobiler.Core.PointS(2.0!, 56.0!)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.SizeF(116.0!, 25.0!)
        Me.txtNote.TabIndex = 10
        Me.txtNote.WaterMarkText = "备注信息"
        '
        'Save
        '
        Me.Save.IconID = "Save"
        Me.Save.Name = "Save"
        Me.Save.Text = "保存"
        '
        'Back
        '
        Me.Back.IconID = "Back"
        Me.Back.Name = "Back"
        Me.Back.Text = "返回"
        '
        'frmCreate
        '
        Me.Controls.AddRange(New Smobiler.Core.Controls.MobileControl() {Me.Label1, Me.txtNO, Me.Label2, Me.txtName, Me.Label3, Me.txtContact, Me.Label4, Me.txtAdress, Me.txtNote})
        Me.TitleText = "新建客户"
        Me.Toolbar.AddRange(New Smobiler.Core.Controls.ToolbarItem() {Me.Save, Me.Back})

    End Sub
    Friend WithEvents Label1 As Smobiler.Core.Controls.Label
    Friend WithEvents txtNO As Smobiler.Core.Controls.TextBox
    Friend WithEvents Label2 As Smobiler.Core.Controls.Label
    Friend WithEvents txtName As Smobiler.Core.Controls.TextBox
    Friend WithEvents Label3 As Smobiler.Core.Controls.Label
    Friend WithEvents txtContact As Smobiler.Core.Controls.TextBox
    Friend WithEvents Label4 As Smobiler.Core.Controls.Label
    Friend WithEvents txtAdress As Smobiler.Core.Controls.TextBox
    Friend WithEvents txtNote As Smobiler.Core.Controls.TextBox
    Friend WithEvents Save As Smobiler.Core.Controls.ToolbarItem
    Friend WithEvents Back As Smobiler.Core.Controls.ToolbarItem

#End Region

End Class
