<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_msgnode
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.uc_Sender = New IpicIndirect.uc_inputbox()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.uc_date = New IpicIndirect.uc_date()
        Me.uc_time = New IpicIndirect.uc_time()
        Me.Uc_label2 = New IpicIndirect.uc_label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(273, 286)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(60, 20)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Visible = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(8, 35)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBox2.Size = New System.Drawing.Size(574, 20)
        Me.RichTextBox2.TabIndex = 11
        Me.RichTextBox2.Text = ""
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(8, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Open File"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.uc_Sender)
        Me.Panel1.Controls.Add(Me.uc_date)
        Me.Panel1.Controls.Add(Me.uc_time)
        Me.Panel1.Location = New System.Drawing.Point(111, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 26)
        Me.Panel1.TabIndex = 14
        '
        'uc_Sender
        '
        Me.uc_Sender.BackColor = System.Drawing.Color.Transparent
        Me.uc_Sender.iAdditional = Nothing
        Me.uc_Sender.iArrow_Visible = False
        Me.uc_Sender.iCanFindLabel_SQLIDx = 0
        Me.uc_Sender.iCharacterLimit = 0
        Me.uc_Sender.idsc = Me.Uc_label1
        Me.uc_Sender.iForm = Nothing
        Me.uc_Sender.iIsDropDown = False
        Me.uc_Sender.iIsEnabled = True
        Me.uc_Sender.iIsForSearch = False
        Me.uc_Sender.iIsID = False
        Me.uc_Sender.iIsInnerShow = False
        Me.uc_Sender.iLabel = "Sender"
        Me.uc_Sender.iLabel_width = 90
        Me.uc_Sender.isAllowEmptyx = True
        Me.uc_Sender.isForFind = False
        Me.uc_Sender.iSQL_Parameter_ID = 0
        Me.uc_Sender.iSQL_Parameter_ID_FIND = 0
        Me.uc_Sender.iText = ""
        Me.uc_Sender.iTextBox_ = Me.TextBox1
        Me.uc_Sender.iTextBox_Sel_COL_ID = 0
        Me.uc_Sender.iTitle = ""
        Me.uc_Sender.LinkedColumn = ""
        Me.uc_Sender.Location = New System.Drawing.Point(6, 2)
        Me.uc_Sender.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_Sender.Name = "uc_Sender"
        Me.uc_Sender.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_Sender.Size = New System.Drawing.Size(290, 24)
        Me.uc_Sender.TabIndex = 7
        '
        'Uc_label1
        '
        Me.Uc_label1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label1.iAddition_SQL = Nothing
        Me.Uc_label1.iAdditional = Nothing
        Me.Uc_label1.idsc = Nothing
        Me.Uc_label1.iIsEnabled = True
        Me.Uc_label1.iIsForSearch = False
        Me.Uc_label1.iLabel = "Edit iLbl to edit me"
        Me.Uc_label1.iLabel_width = 0
        Me.Uc_label1.isLabelBoldx = False
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.LinkedColumn = ""
        Me.Uc_label1.Location = New System.Drawing.Point(273, 312)
        Me.Uc_label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(60, 16)
        Me.Uc_label1.TabIndex = 8
        Me.Uc_label1.Visible = False
        '
        'uc_date
        '
        Me.uc_date.BackColor = System.Drawing.Color.Transparent
        Me.uc_date.iDate = New Date(2020, 8, 3, 17, 45, 48, 759)
        Me.uc_date.idsc = Nothing
        Me.uc_date.iForm = Nothing
        Me.uc_date.iIsForSearch = False
        Me.uc_date.iLabel = "-"
        Me.uc_date.iLabel_width = 10
        Me.uc_date.IsEnabled = False
        Me.uc_date.isForFind = False
        Me.uc_date.iSQL_Parameter_ID = 0
        Me.uc_date.LinkedColumn = ""
        Me.uc_date.Location = New System.Drawing.Point(300, 2)
        Me.uc_date.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_date.Name = "uc_date"
        Me.uc_date.Size = New System.Drawing.Size(87, 23)
        Me.uc_date.TabIndex = 5
        '
        'uc_time
        '
        Me.uc_time.BackColor = System.Drawing.Color.Transparent
        Me.uc_time.iDate = New Date(2020, 8, 3, 17, 45, 48, 764)
        Me.uc_time.idsc = Nothing
        Me.uc_time.iForm = Nothing
        Me.uc_time.iIsForSearch = False
        Me.uc_time.iLabel = "Production Order Selection"
        Me.uc_time.iLabel_width = 10
        Me.uc_time.IsEnabled = False
        Me.uc_time.isForFind = False
        Me.uc_time.iSQL_Parameter_ID = 0
        Me.uc_time.LinkedColumn = ""
        Me.uc_time.Location = New System.Drawing.Point(386, 2)
        Me.uc_time.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_time.Name = "uc_time"
        Me.uc_time.Size = New System.Drawing.Size(89, 23)
        Me.uc_time.TabIndex = 6
        '
        'Uc_label2
        '
        Me.Uc_label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_label2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label2.iAddition_SQL = Nothing
        Me.Uc_label2.iAdditional = Nothing
        Me.Uc_label2.idsc = Nothing
        Me.Uc_label2.iIsEnabled = True
        Me.Uc_label2.iIsForSearch = False
        Me.Uc_label2.iLabel = ""
        Me.Uc_label2.iLabel_width = 5000
        Me.Uc_label2.isLabelBoldx = False
        Me.Uc_label2.iSQL_Parameter_ID = 0
        Me.Uc_label2.iText = ""
        Me.Uc_label2.LinkedColumn = ""
        Me.Uc_label2.Location = New System.Drawing.Point(0, 69)
        Me.Uc_label2.Name = "Uc_label2"
        Me.Uc_label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label2.Size = New System.Drawing.Size(605, 20)
        Me.Uc_label2.TabIndex = 15
        '
        'uc_msgnode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Uc_label1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Uc_label2)
        Me.Name = "uc_msgnode"
        Me.Size = New System.Drawing.Size(591, 105)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uc_Sender As uc_inputbox
    Friend WithEvents uc_time As uc_time
    Friend WithEvents uc_date As uc_date
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Uc_label2 As uc_label
End Class
