<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_dgv_col_withArrow
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
        Me.lbl = New System.Windows.Forms.Label()
        Me.btn_Item_arrow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(25, 3)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(35, 13)
        Me.lbl.TabIndex = 111
        Me.lbl.Text = "TEST"
        '
        'btn_Item_arrow
        '
        Me.btn_Item_arrow.BackColor = System.Drawing.Color.Transparent
        Me.btn_Item_arrow.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.GoldArrow2
        Me.btn_Item_arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Item_arrow.FlatAppearance.BorderSize = 0
        Me.btn_Item_arrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Item_arrow.Location = New System.Drawing.Point(3, 1)
        Me.btn_Item_arrow.Name = "btn_Item_arrow"
        Me.btn_Item_arrow.Size = New System.Drawing.Size(16, 16)
        Me.btn_Item_arrow.TabIndex = 110
        Me.btn_Item_arrow.UseVisualStyleBackColor = False
        '
        'uc_dgv_col_withArrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btn_Item_arrow)
        Me.Name = "uc_dgv_col_withArrow"
        Me.Size = New System.Drawing.Size(68, 19)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Item_arrow As Button
    Friend WithEvents lbl As Label
End Class
