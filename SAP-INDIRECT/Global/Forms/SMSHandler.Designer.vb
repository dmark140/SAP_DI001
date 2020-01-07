<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMSHandler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMSHandler))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.uc_lstDate = New IpicIndirect.uc_label()
        Me.uc_msgSend = New IpicIndirect.uc_label()
        Me.uc_errcounter = New IpicIndirect.uc_label()
        Me.uc_port = New IpicIndirect.uc_label()
        Me.MetroProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "IPIC SMS HANDLER"
        Me.NotifyIcon1.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'uc_lstDate
        '
        Me.uc_lstDate.BackColor = System.Drawing.Color.Transparent
        Me.uc_lstDate.iAddition_SQL = Nothing
        Me.uc_lstDate.iAdditional = Nothing
        Me.uc_lstDate.idsc = Nothing
        Me.uc_lstDate.iIsEnabled = False
        Me.uc_lstDate.iIsForSearch = False
        Me.uc_lstDate.iLabel = "Last Msg Sent"
        Me.uc_lstDate.iLabel_width = 120
        Me.uc_lstDate.isLabelBoldx = False
        Me.uc_lstDate.iSQL_Parameter_ID = 0
        Me.uc_lstDate.iText = ""
        Me.uc_lstDate.LinkedColumn = ""
        Me.uc_lstDate.Location = New System.Drawing.Point(12, 111)
        Me.uc_lstDate.Name = "uc_lstDate"
        Me.uc_lstDate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lstDate.Size = New System.Drawing.Size(275, 27)
        Me.uc_lstDate.TabIndex = 0
        '
        'uc_msgSend
        '
        Me.uc_msgSend.BackColor = System.Drawing.Color.Transparent
        Me.uc_msgSend.iAddition_SQL = Nothing
        Me.uc_msgSend.iAdditional = Nothing
        Me.uc_msgSend.idsc = Nothing
        Me.uc_msgSend.iIsEnabled = False
        Me.uc_msgSend.iIsForSearch = False
        Me.uc_msgSend.iLabel = "Msg Sendt"
        Me.uc_msgSend.iLabel_width = 120
        Me.uc_msgSend.isLabelBoldx = False
        Me.uc_msgSend.iSQL_Parameter_ID = 0
        Me.uc_msgSend.iText = ""
        Me.uc_msgSend.LinkedColumn = ""
        Me.uc_msgSend.Location = New System.Drawing.Point(12, 78)
        Me.uc_msgSend.Name = "uc_msgSend"
        Me.uc_msgSend.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_msgSend.Size = New System.Drawing.Size(275, 27)
        Me.uc_msgSend.TabIndex = 0
        '
        'uc_errcounter
        '
        Me.uc_errcounter.BackColor = System.Drawing.Color.Transparent
        Me.uc_errcounter.iAddition_SQL = Nothing
        Me.uc_errcounter.iAdditional = Nothing
        Me.uc_errcounter.idsc = Nothing
        Me.uc_errcounter.iIsEnabled = True
        Me.uc_errcounter.iIsForSearch = False
        Me.uc_errcounter.iLabel = "Error Counter"
        Me.uc_errcounter.iLabel_width = 120
        Me.uc_errcounter.isLabelBoldx = False
        Me.uc_errcounter.iSQL_Parameter_ID = 0
        Me.uc_errcounter.iText = ""
        Me.uc_errcounter.LinkedColumn = ""
        Me.uc_errcounter.Location = New System.Drawing.Point(12, 45)
        Me.uc_errcounter.Name = "uc_errcounter"
        Me.uc_errcounter.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_errcounter.Size = New System.Drawing.Size(275, 27)
        Me.uc_errcounter.TabIndex = 0
        '
        'uc_port
        '
        Me.uc_port.BackColor = System.Drawing.Color.Transparent
        Me.uc_port.iAddition_SQL = Nothing
        Me.uc_port.iAdditional = Nothing
        Me.uc_port.idsc = Nothing
        Me.uc_port.iIsEnabled = True
        Me.uc_port.iIsForSearch = False
        Me.uc_port.iLabel = "Port "
        Me.uc_port.iLabel_width = 120
        Me.uc_port.isLabelBoldx = False
        Me.uc_port.iSQL_Parameter_ID = 0
        Me.uc_port.iText = ""
        Me.uc_port.LinkedColumn = ""
        Me.uc_port.Location = New System.Drawing.Point(12, 12)
        Me.uc_port.Name = "uc_port"
        Me.uc_port.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_port.Size = New System.Drawing.Size(275, 27)
        Me.uc_port.TabIndex = 0
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(264, 139)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(18, 17)
        Me.MetroProgressSpinner1.TabIndex = 1
        Me.MetroProgressSpinner1.UseSelectable = True
        Me.MetroProgressSpinner1.Value = 2
        '
        'SMSHandler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 164)
        Me.Controls.Add(Me.MetroProgressSpinner1)
        Me.Controls.Add(Me.uc_lstDate)
        Me.Controls.Add(Me.uc_msgSend)
        Me.Controls.Add(Me.uc_errcounter)
        Me.Controls.Add(Me.uc_port)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SMSHandler"
        Me.Text = "IPIC SMS Handler"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents uc_port As uc_label
    Friend WithEvents uc_errcounter As uc_label
    Friend WithEvents uc_msgSend As uc_label
    Friend WithEvents uc_lstDate As uc_label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MetroProgressSpinner1 As MetroFramework.Controls.MetroProgressSpinner
End Class
