<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUpAndNotificationSender
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_users = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_msg = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_subject = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Uc_label3 = New IpicIndirect.uc_label()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.Uc_label2 = New IpicIndirect.uc_label()
        Me.uc_ToWHse_lbl = New IpicIndirect.uc_label()
        Me.Uc_label4 = New IpicIndirect.uc_label()
        Me.uc_number = New System.Windows.Forms.TextBox()
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_users
        '
        Me.dgv_users.AllowUserToAddRows = False
        Me.dgv_users.AllowUserToDeleteRows = False
        Me.dgv_users.BackgroundColor = System.Drawing.Color.White
        Me.dgv_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_users.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_users.EnableHeadersVisualStyles = False
        Me.dgv_users.Location = New System.Drawing.Point(12, 40)
        Me.dgv_users.Name = "dgv_users"
        Me.dgv_users.ReadOnly = True
        Me.dgv_users.RowHeadersVisible = False
        Me.dgv_users.RowTemplate.Height = 24
        Me.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_users.Size = New System.Drawing.Size(256, 306)
        Me.dgv_users.TabIndex = 92
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(396, 40)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 52)
        Me.TextBox1.TabIndex = 94
        '
        'txt_msg
        '
        Me.txt_msg.Location = New System.Drawing.Point(396, 154)
        Me.txt_msg.Multiline = True
        Me.txt_msg.Name = "txt_msg"
        Me.txt_msg.Size = New System.Drawing.Size(344, 190)
        Me.txt_msg.TabIndex = 95
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Image = Global.IpicIndirect.My.Resources.Resources.right
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(665, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Send"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_subject
        '
        Me.txt_subject.Location = New System.Drawing.Point(396, 128)
        Me.txt_subject.Multiline = True
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Size = New System.Drawing.Size(344, 20)
        Me.txt_subject.TabIndex = 95
        '
        'Uc_label3
        '
        Me.Uc_label3.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label3.iAddition_SQL = Nothing
        Me.Uc_label3.iAdditional = Nothing
        Me.Uc_label3.idsc = Nothing
        Me.Uc_label3.iIsEnabled = True
        Me.Uc_label3.iIsForSearch = False
        Me.Uc_label3.iLabel = "Subject"
        Me.Uc_label3.iLabel_width = 500
        Me.Uc_label3.isLabelBoldx = False
        Me.Uc_label3.iSQL_Parameter_ID = 0
        Me.Uc_label3.iText = ""
        Me.Uc_label3.Location = New System.Drawing.Point(276, 128)
        Me.Uc_label3.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label3.Name = "Uc_label3"
        Me.Uc_label3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label3.Size = New System.Drawing.Size(207, 22)
        Me.Uc_label3.TabIndex = 96
        '
        'Uc_label1
        '
        Me.Uc_label1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label1.iAddition_SQL = Nothing
        Me.Uc_label1.iAdditional = Nothing
        Me.Uc_label1.idsc = Nothing
        Me.Uc_label1.iIsEnabled = True
        Me.Uc_label1.iIsForSearch = False
        Me.Uc_label1.iLabel = "MSS"
        Me.Uc_label1.iLabel_width = 500
        Me.Uc_label1.isLabelBoldx = False
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.Location = New System.Drawing.Point(276, 324)
        Me.Uc_label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(207, 22)
        Me.Uc_label1.TabIndex = 96
        '
        'Uc_label2
        '
        Me.Uc_label2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label2.iAddition_SQL = Nothing
        Me.Uc_label2.iAdditional = Nothing
        Me.Uc_label2.idsc = Nothing
        Me.Uc_label2.iIsEnabled = True
        Me.Uc_label2.iIsForSearch = False
        Me.Uc_label2.iLabel = "User List"
        Me.Uc_label2.iLabel_width = 500
        Me.Uc_label2.isLabelBoldx = True
        Me.Uc_label2.iSQL_Parameter_ID = 0
        Me.Uc_label2.iText = ""
        Me.Uc_label2.Location = New System.Drawing.Point(12, 10)
        Me.Uc_label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label2.Name = "Uc_label2"
        Me.Uc_label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label2.Size = New System.Drawing.Size(85, 22)
        Me.Uc_label2.TabIndex = 96
        '
        'uc_ToWHse_lbl
        '
        Me.uc_ToWHse_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_ToWHse_lbl.iAddition_SQL = Nothing
        Me.uc_ToWHse_lbl.iAdditional = Nothing
        Me.uc_ToWHse_lbl.idsc = Nothing
        Me.uc_ToWHse_lbl.iIsEnabled = True
        Me.uc_ToWHse_lbl.iIsForSearch = False
        Me.uc_ToWHse_lbl.iLabel = "Selected User"
        Me.uc_ToWHse_lbl.iLabel_width = 500
        Me.uc_ToWHse_lbl.isLabelBoldx = False
        Me.uc_ToWHse_lbl.iSQL_Parameter_ID = 0
        Me.uc_ToWHse_lbl.iText = ""
        Me.uc_ToWHse_lbl.Location = New System.Drawing.Point(276, 72)
        Me.uc_ToWHse_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_ToWHse_lbl.Name = "uc_ToWHse_lbl"
        Me.uc_ToWHse_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_ToWHse_lbl.Size = New System.Drawing.Size(207, 22)
        Me.uc_ToWHse_lbl.TabIndex = 96
        '
        'Uc_label4
        '
        Me.Uc_label4.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label4.iAddition_SQL = Nothing
        Me.Uc_label4.iAdditional = Nothing
        Me.Uc_label4.idsc = Nothing
        Me.Uc_label4.iIsEnabled = True
        Me.Uc_label4.iIsForSearch = False
        Me.Uc_label4.iLabel = "Number"
        Me.Uc_label4.iLabel_width = 500
        Me.Uc_label4.isLabelBoldx = False
        Me.Uc_label4.iSQL_Parameter_ID = 0
        Me.Uc_label4.iText = ""
        Me.Uc_label4.Location = New System.Drawing.Point(276, 104)
        Me.Uc_label4.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label4.Name = "Uc_label4"
        Me.Uc_label4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label4.Size = New System.Drawing.Size(207, 22)
        Me.Uc_label4.TabIndex = 96
        '
        'uc_number
        '
        Me.uc_number.Location = New System.Drawing.Point(396, 104)
        Me.uc_number.Multiline = True
        Me.uc_number.Name = "uc_number"
        Me.uc_number.Size = New System.Drawing.Size(344, 20)
        Me.uc_number.TabIndex = 95
        '
        'PopUpAndNotificationSender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 380)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.uc_number)
        Me.Controls.Add(Me.txt_subject)
        Me.Controls.Add(Me.Uc_label4)
        Me.Controls.Add(Me.txt_msg)
        Me.Controls.Add(Me.Uc_label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Uc_label1)
        Me.Controls.Add(Me.Uc_label2)
        Me.Controls.Add(Me.uc_ToWHse_lbl)
        Me.Controls.Add(Me.dgv_users)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PopUpAndNotificationSender"
        Me.Text = "PopUpAndNotificationSender"
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_users As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_msg As TextBox
    Friend WithEvents uc_ToWHse_lbl As uc_label
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents Button1 As Button
    Friend WithEvents Uc_label2 As uc_label
    Friend WithEvents Uc_label3 As uc_label
    Friend WithEvents txt_subject As TextBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Uc_label4 As uc_label
    Friend WithEvents uc_number As TextBox
End Class
