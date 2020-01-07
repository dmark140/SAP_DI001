<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EDS_Warehouse
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_1 = New System.Windows.Forms.DataGridView()
        Me.c_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_cell_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmd_edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmd_delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmd_help = New System.Windows.Forms.ToolStripMenuItem()
        Me.C_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_MACHINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmd_cell_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(253, 483)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(84, 23)
        Me.btn_update.TabIndex = 122
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(8, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(330, 17)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Warehouse list"
        '
        'dgv_1
        '
        Me.dgv_1.AllowUserToAddRows = False
        Me.dgv_1.AllowUserToDeleteRows = False
        Me.dgv_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_1.BackgroundColor = System.Drawing.Color.White
        Me.dgv_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_id, Me.C_CODE, Me.C_MACHINE})
        Me.dgv_1.EnableHeadersVisualStyles = False
        Me.dgv_1.Location = New System.Drawing.Point(10, 31)
        Me.dgv_1.Name = "dgv_1"
        Me.dgv_1.RowHeadersVisible = False
        Me.dgv_1.RowTemplate.Height = 24
        Me.dgv_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_1.Size = New System.Drawing.Size(327, 444)
        Me.dgv_1.TabIndex = 120
        '
        'c_id
        '
        Me.c_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.c_id.ContextMenuStrip = Me.cmd_cell_menu
        Me.c_id.FillWeight = 20.0!
        Me.c_id.Frozen = True
        Me.c_id.HeaderText = "ID"
        Me.c_id.Name = "c_id"
        Me.c_id.ReadOnly = True
        Me.c_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.c_id.Width = 39
        '
        'cmd_cell_menu
        '
        Me.cmd_cell_menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmd_cell_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_edit, Me.cmd_delete, Me.ToolStripSeparator1, Me.cmd_help})
        Me.cmd_cell_menu.Name = "ContextMenuStrip1"
        Me.cmd_cell_menu.Size = New System.Drawing.Size(108, 76)
        '
        'cmd_edit
        '
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(107, 22)
        Me.cmd_edit.Text = "Edit"
        '
        'cmd_delete
        '
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(107, 22)
        Me.cmd_delete.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(104, 6)
        '
        'cmd_help
        '
        Me.cmd_help.Name = "cmd_help"
        Me.cmd_help.Size = New System.Drawing.Size(107, 22)
        Me.cmd_help.Text = "Help"
        '
        'C_CODE
        '
        Me.C_CODE.HeaderText = "CODE"
        Me.C_CODE.Name = "C_CODE"
        '
        'C_MACHINE
        '
        Me.C_MACHINE.HeaderText = "MACHINE NAME"
        Me.C_MACHINE.Name = "C_MACHINE"
        '
        'EDS_Warehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(349, 521)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgv_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "EDS_Warehouse"
        Me.Text = "EDS_Warehouse"
        CType(Me.dgv_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmd_cell_menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv_1 As DataGridView
    Friend WithEvents cmd_cell_menu As ContextMenuStrip
    Friend WithEvents cmd_edit As ToolStripMenuItem
    Friend WithEvents cmd_delete As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmd_help As ToolStripMenuItem
    Friend WithEvents c_id As DataGridViewTextBoxColumn
    Friend WithEvents C_CODE As DataGridViewTextBoxColumn
    Friend WithEvents C_MACHINE As DataGridViewTextBoxColumn
End Class
