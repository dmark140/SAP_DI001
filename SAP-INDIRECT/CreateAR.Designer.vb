<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateAR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtqty = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtitemcode = New System.Windows.Forms.MaskedTextBox()
        Me.txtAvailQty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprices = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDateDue = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdocentry = New System.Windows.Forms.TextBox()
        Me.txtcardname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlinenum = New System.Windows.Forms.MaskedTextBox()
        Me.txtobjtype = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcardcode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcashAcc = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroButton2
        '
        Me.MetroButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton2.BackColor = System.Drawing.Color.Black
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.ForeColor = System.Drawing.Color.White
        Me.MetroButton2.Location = New System.Drawing.Point(880, -1)
        Me.MetroButton2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(20, 20)
        Me.MetroButton2.TabIndex = 10
        Me.MetroButton2.Text = "X"
        Me.MetroButton2.UseSelectable = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column15, Me.Column11, Me.Column2, Me.Column4, Me.Column3, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(505, 533)
        Me.DataGridView1.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 39
        '
        'Column15
        '
        Me.Column15.HeaderText = "Card Code"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Card Name"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Doc. Entry"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 94
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Line Num"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Obj. Type"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Due Date"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Prices"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "Qty"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "itemcode"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'txtqty
        '
        '
        '
        '
        Me.txtqty.CustomButton.Image = Nothing
        Me.txtqty.CustomButton.Location = New System.Drawing.Point(100, 2)
        Me.txtqty.CustomButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtqty.CustomButton.Name = ""
        Me.txtqty.CustomButton.Size = New System.Drawing.Size(14, 15)
        Me.txtqty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtqty.CustomButton.TabIndex = 1
        Me.txtqty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtqty.CustomButton.UseSelectable = True
        Me.txtqty.CustomButton.Visible = False
        Me.txtqty.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtqty.Lines = New String(-1) {}
        Me.txtqty.Location = New System.Drawing.Point(528, 302)
        Me.txtqty.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtqty.MaxLength = 32767
        Me.txtqty.Name = "txtqty"
        Me.txtqty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtqty.PromptText = "Input Quantity"
        Me.txtqty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtqty.SelectedText = ""
        Me.txtqty.SelectionLength = 0
        Me.txtqty.SelectionStart = 0
        Me.txtqty.ShortcutsEnabled = True
        Me.txtqty.Size = New System.Drawing.Size(156, 24)
        Me.txtqty.TabIndex = 14
        Me.txtqty.UseSelectable = True
        Me.txtqty.WaterMark = "Input Quantity"
        Me.txtqty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtqty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtitemcode)
        Me.Panel1.Controls.Add(Me.txtAvailQty)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtprices)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtDateDue)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtdocentry)
        Me.Panel1.Controls.Add(Me.txtcardname)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtlinenum)
        Me.Panel1.Controls.Add(Me.txtobjtype)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtcardcode)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(515, 41)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 204)
        Me.Panel1.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(171, 115)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Item Code"
        '
        'txtitemcode
        '
        Me.txtitemcode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemcode.Location = New System.Drawing.Point(171, 131)
        Me.txtitemcode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtitemcode.Name = "txtitemcode"
        Me.txtitemcode.Size = New System.Drawing.Size(78, 22)
        Me.txtitemcode.TabIndex = 40
        '
        'txtAvailQty
        '
        Me.txtAvailQty.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailQty.Location = New System.Drawing.Point(94, 171)
        Me.txtAvailQty.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAvailQty.Name = "txtAvailQty"
        Me.txtAvailQty.Size = New System.Drawing.Size(75, 22)
        Me.txtAvailQty.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 155)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Quantity"
        '
        'txtprices
        '
        Me.txtprices.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprices.Location = New System.Drawing.Point(173, 171)
        Me.txtprices.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtprices.Name = "txtprices"
        Me.txtprices.Size = New System.Drawing.Size(75, 22)
        Me.txtprices.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(171, 155)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Price per Line"
        '
        'txtDateDue
        '
        Me.txtDateDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateDue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDateDue.Location = New System.Drawing.Point(154, 25)
        Me.txtDateDue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDateDue.Name = "txtDateDue"
        Me.txtDateDue.Size = New System.Drawing.Size(95, 21)
        Me.txtDateDue.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 115)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Doc. Entry"
        '
        'txtdocentry
        '
        Me.txtdocentry.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdocentry.Location = New System.Drawing.Point(14, 131)
        Me.txtdocentry.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdocentry.Name = "txtdocentry"
        Me.txtdocentry.Size = New System.Drawing.Size(78, 22)
        Me.txtdocentry.TabIndex = 30
        '
        'txtcardname
        '
        Me.txtcardname.Location = New System.Drawing.Point(11, 65)
        Me.txtcardname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcardname.Multiline = True
        Me.txtcardname.Name = "txtcardname"
        Me.txtcardname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcardname.Size = New System.Drawing.Size(237, 48)
        Me.txtcardname.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 155)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Line Num."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Object Type"
        '
        'txtlinenum
        '
        Me.txtlinenum.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlinenum.Location = New System.Drawing.Point(14, 171)
        Me.txtlinenum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtlinenum.Name = "txtlinenum"
        Me.txtlinenum.Size = New System.Drawing.Size(78, 22)
        Me.txtlinenum.TabIndex = 26
        '
        'txtobjtype
        '
        Me.txtobjtype.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobjtype.Location = New System.Drawing.Point(92, 131)
        Me.txtobjtype.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtobjtype.Name = "txtobjtype"
        Me.txtobjtype.Size = New System.Drawing.Size(78, 22)
        Me.txtobjtype.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Card Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Card Code"
        '
        'txtcardcode
        '
        Me.txtcardcode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcardcode.Location = New System.Drawing.Point(11, 25)
        Me.txtcardcode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcardcode.Name = "txtcardcode"
        Me.txtcardcode.Size = New System.Drawing.Size(139, 22)
        Me.txtcardcode.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(529, 332)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 34)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtcashAcc
        '
        Me.txtcashAcc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcashAcc.FormattingEnabled = True
        Me.txtcashAcc.Location = New System.Drawing.Point(529, 275)
        Me.txtcashAcc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcashAcc.Name = "txtcashAcc"
        Me.txtcashAcc.Size = New System.Drawing.Size(156, 25)
        Me.txtcashAcc.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(530, 258)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Cash Account"
        '
        'CreateAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(899, 571)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcashAcc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MetroButton2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CreateAR"
        Me.Tag = "0"
        Me.Text = "CreateAR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtqty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtlinenum As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcardcode As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcardname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdocentry As TextBox
    Friend WithEvents txtobjtype As TextBox
    Friend WithEvents txtDateDue As DateTimePicker
    Friend WithEvents txtprices As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAvailQty As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtitemcode As MaskedTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents txtcashAcc As ComboBox
    Friend WithEvents Label9 As Label
End Class
