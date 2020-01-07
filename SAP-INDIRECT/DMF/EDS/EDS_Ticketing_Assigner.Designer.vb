<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDS_Ticketing_Assigner
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.dgv_1 = New System.Windows.Forms.DataGridView()
        Me.dgv_2 = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(17, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(435, 21)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Tickting users"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(483, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 21)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Ticketing super users"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(817, 588)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(100, 30)
        Me.btn_update.TabIndex = 115
        Me.btn_update.Text = "Update"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'dgv_1
        '
        Me.dgv_1.AllowUserToAddRows = False
        Me.dgv_1.AllowUserToDeleteRows = False
        Me.dgv_1.BackgroundColor = System.Drawing.Color.White
        Me.dgv_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_1.EnableHeadersVisualStyles = False
        Me.dgv_1.Location = New System.Drawing.Point(16, 32)
        Me.dgv_1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_1.Name = "dgv_1"
        Me.dgv_1.ReadOnly = True
        Me.dgv_1.RowHeadersVisible = False
        Me.dgv_1.RowTemplate.Height = 24
        Me.dgv_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_1.Size = New System.Drawing.Size(436, 549)
        Me.dgv_1.TabIndex = 116
        '
        'dgv_2
        '
        Me.dgv_2.AllowUserToAddRows = False
        Me.dgv_2.AllowUserToDeleteRows = False
        Me.dgv_2.BackgroundColor = System.Drawing.Color.White
        Me.dgv_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_2.EnableHeadersVisualStyles = False
        Me.dgv_2.Location = New System.Drawing.Point(483, 32)
        Me.dgv_2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_2.Name = "dgv_2"
        Me.dgv_2.ReadOnly = True
        Me.dgv_2.RowHeadersVisible = False
        Me.dgv_2.RowTemplate.Height = 24
        Me.dgv_2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_2.Size = New System.Drawing.Size(436, 549)
        Me.dgv_2.TabIndex = 117
        '
        'EDS_Ticketing_Assigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 629)
        Me.Controls.Add(Me.dgv_2)
        Me.Controls.Add(Me.dgv_1)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "EDS_Ticketing_Assigner"
        Me.Text = "EDS_Ticketing_Assigner"
        CType(Me.dgv_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents dgv_1 As DataGridView
    Friend WithEvents dgv_2 As DataGridView
End Class
