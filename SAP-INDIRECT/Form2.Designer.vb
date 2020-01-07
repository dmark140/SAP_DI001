<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServerType = New MetroFramework.Controls.MetroComboBox()
        Me.txtServer = New MetroFramework.Controls.MetroTextBox()
        Me.txtdn = New MetroFramework.Controls.MetroTextBox()
        Me.txtsapu = New MetroFramework.Controls.MetroTextBox()
        Me.txtsapp = New MetroFramework.Controls.MetroTextBox()
        Me.txtdbu = New MetroFramework.Controls.MetroTextBox()
        Me.txtdbp = New MetroFramework.Controls.MetroTextBox()
        Me.txtsl = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 455)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 63)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LOADING....."
        '
        'PictureBox1
        '

        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SYSTEM CONFIG"
        '
        'txtServerType
        '
        Me.txtServerType.FormattingEnabled = True
        Me.txtServerType.ItemHeight = 23
        Me.txtServerType.Location = New System.Drawing.Point(19, 247)
        Me.txtServerType.Name = "txtServerType"
        Me.txtServerType.Size = New System.Drawing.Size(328, 29)
        Me.txtServerType.TabIndex = 4
        Me.txtServerType.UseSelectable = True
        '
        'txtServer
        '
        '
        '
        '
        Me.txtServer.CustomButton.Image = Nothing
        Me.txtServer.CustomButton.Location = New System.Drawing.Point(294, 1)
        Me.txtServer.CustomButton.Name = ""
        Me.txtServer.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtServer.CustomButton.TabIndex = 1
        Me.txtServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtServer.CustomButton.UseSelectable = True
        Me.txtServer.CustomButton.Visible = False
        Me.txtServer.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtServer.Lines = New String(-1) {}
        Me.txtServer.Location = New System.Drawing.Point(19, 83)
        Me.txtServer.MaxLength = 32767
        Me.txtServer.Name = "txtServer"
        Me.txtServer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServer.PromptText = "Server"
        Me.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtServer.SelectedText = ""
        Me.txtServer.SelectionLength = 0
        Me.txtServer.SelectionStart = 0
        Me.txtServer.ShortcutsEnabled = True
        Me.txtServer.Size = New System.Drawing.Size(328, 35)
        Me.txtServer.TabIndex = 0
        Me.txtServer.UseSelectable = True
        Me.txtServer.WaterMark = "Server"
        Me.txtServer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtServer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtdn
        '
        '
        '
        '
        Me.txtdn.CustomButton.Image = Nothing
        Me.txtdn.CustomButton.Location = New System.Drawing.Point(294, 1)
        Me.txtdn.CustomButton.Name = ""
        Me.txtdn.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtdn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdn.CustomButton.TabIndex = 1
        Me.txtdn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdn.CustomButton.UseSelectable = True
        Me.txtdn.CustomButton.Visible = False
        Me.txtdn.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtdn.Lines = New String(-1) {}
        Me.txtdn.Location = New System.Drawing.Point(19, 124)
        Me.txtdn.MaxLength = 32767
        Me.txtdn.Name = "txtdn"
        Me.txtdn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdn.PromptText = "Database Name"
        Me.txtdn.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdn.SelectedText = ""
        Me.txtdn.SelectionLength = 0
        Me.txtdn.SelectionStart = 0
        Me.txtdn.ShortcutsEnabled = True
        Me.txtdn.Size = New System.Drawing.Size(328, 35)
        Me.txtdn.TabIndex = 1
        Me.txtdn.UseSelectable = True
        Me.txtdn.WaterMark = "Database Name"
        Me.txtdn.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdn.WaterMarkFont = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtsapu
        '
        '
        '
        '
        Me.txtsapu.CustomButton.Image = Nothing
        Me.txtsapu.CustomButton.Location = New System.Drawing.Point(294, 1)
        Me.txtsapu.CustomButton.Name = ""
        Me.txtsapu.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtsapu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsapu.CustomButton.TabIndex = 1
        Me.txtsapu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsapu.CustomButton.UseSelectable = True
        Me.txtsapu.CustomButton.Visible = False
        Me.txtsapu.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtsapu.Lines = New String(-1) {}
        Me.txtsapu.Location = New System.Drawing.Point(19, 165)
        Me.txtsapu.MaxLength = 32767
        Me.txtsapu.Name = "txtsapu"
        Me.txtsapu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsapu.PromptText = "SAP Username"
        Me.txtsapu.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsapu.SelectedText = ""
        Me.txtsapu.SelectionLength = 0
        Me.txtsapu.SelectionStart = 0
        Me.txtsapu.ShortcutsEnabled = True
        Me.txtsapu.Size = New System.Drawing.Size(328, 35)
        Me.txtsapu.TabIndex = 2
        Me.txtsapu.UseSelectable = True
        Me.txtsapu.WaterMark = "SAP Username"
        Me.txtsapu.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsapu.WaterMarkFont = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtsapp
        '
        '
        '
        '
        Me.txtsapp.CustomButton.Image = Nothing
        Me.txtsapp.CustomButton.Location = New System.Drawing.Point(294, 1)
        Me.txtsapp.CustomButton.Name = ""
        Me.txtsapp.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtsapp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsapp.CustomButton.TabIndex = 1
        Me.txtsapp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsapp.CustomButton.UseSelectable = True
        Me.txtsapp.CustomButton.Visible = False
        Me.txtsapp.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtsapp.Lines = New String(-1) {}
        Me.txtsapp.Location = New System.Drawing.Point(19, 206)
        Me.txtsapp.MaxLength = 32767
        Me.txtsapp.Name = "txtsapp"
        Me.txtsapp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtsapp.PromptText = "SAP Password"
        Me.txtsapp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsapp.SelectedText = ""
        Me.txtsapp.SelectionLength = 0
        Me.txtsapp.SelectionStart = 0
        Me.txtsapp.ShortcutsEnabled = True
        Me.txtsapp.Size = New System.Drawing.Size(328, 35)
        Me.txtsapp.TabIndex = 3
        Me.txtsapp.UseSelectable = True
        Me.txtsapp.WaterMark = "SAP Password"
        Me.txtsapp.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsapp.WaterMarkFont = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtdbu
        '
        '
        '
        '
        Me.txtdbu.CustomButton.Image = Nothing
        Me.txtdbu.CustomButton.Location = New System.Drawing.Point(294, 1)
        Me.txtdbu.CustomButton.Name = ""
        Me.txtdbu.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtdbu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdbu.CustomButton.TabIndex = 1
        Me.txtdbu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdbu.CustomButton.UseSelectable = True
        Me.txtdbu.CustomButton.Visible = False
        Me.txtdbu.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtdbu.Lines = New String(-1) {}
        Me.txtdbu.Location = New System.Drawing.Point(19, 283)
        Me.txtdbu.MaxLength = 32767
        Me.txtdbu.Name = "txtdbu"
        Me.txtdbu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdbu.PromptText = "DB Username"
        Me.txtdbu.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdbu.SelectedText = ""
        Me.txtdbu.SelectionLength = 0
        Me.txtdbu.SelectionStart = 0
        Me.txtdbu.ShortcutsEnabled = True
        Me.txtdbu.Size = New System.Drawing.Size(328, 35)
        Me.txtdbu.TabIndex = 5
        Me.txtdbu.UseSelectable = True
        Me.txtdbu.WaterMark = "DB Username"
        Me.txtdbu.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdbu.WaterMarkFont = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtdbp
        '
        '
        '
        '
        Me.txtdbp.CustomButton.Image = Nothing
        Me.txtdbp.CustomButton.Location = New System.Drawing.Point(294, 1)
        Me.txtdbp.CustomButton.Name = ""
        Me.txtdbp.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtdbp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdbp.CustomButton.TabIndex = 1
        Me.txtdbp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdbp.CustomButton.UseSelectable = True
        Me.txtdbp.CustomButton.Visible = False
        Me.txtdbp.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtdbp.Lines = New String(-1) {}
        Me.txtdbp.Location = New System.Drawing.Point(19, 324)
        Me.txtdbp.MaxLength = 32767
        Me.txtdbp.Name = "txtdbp"
        Me.txtdbp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtdbp.PromptText = "DB Password"
        Me.txtdbp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdbp.SelectedText = ""
        Me.txtdbp.SelectionLength = 0
        Me.txtdbp.SelectionStart = 0
        Me.txtdbp.ShortcutsEnabled = True
        Me.txtdbp.Size = New System.Drawing.Size(328, 35)
        Me.txtdbp.TabIndex = 6
        Me.txtdbp.UseSelectable = True
        Me.txtdbp.WaterMark = "DB Password"
        Me.txtdbp.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdbp.WaterMarkFont = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtsl
        '
        '
        '
        '
        Me.txtsl.CustomButton.Image = Nothing
        Me.txtsl.CustomButton.Location = New System.Drawing.Point(294, 1)
        Me.txtsl.CustomButton.Name = ""
        Me.txtsl.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtsl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsl.CustomButton.TabIndex = 1
        Me.txtsl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsl.CustomButton.UseSelectable = True
        Me.txtsl.CustomButton.Visible = False
        Me.txtsl.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtsl.Lines = New String(-1) {}
        Me.txtsl.Location = New System.Drawing.Point(19, 368)
        Me.txtsl.MaxLength = 32767
        Me.txtsl.Name = "txtsl"
        Me.txtsl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsl.PromptText = "Server License"
        Me.txtsl.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsl.SelectedText = ""
        Me.txtsl.SelectionLength = 0
        Me.txtsl.SelectionStart = 0
        Me.txtsl.ShortcutsEnabled = True
        Me.txtsl.Size = New System.Drawing.Size(328, 35)
        Me.txtsl.TabIndex = 7
        Me.txtsl.UseSelectable = True
        Me.txtsl.WaterMark = "Server License"
        Me.txtsl.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsl.WaterMarkFont = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroButton1
        '
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.Location = New System.Drawing.Point(19, 409)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(328, 40)
        Me.MetroButton1.TabIndex = 8
        Me.MetroButton1.Text = "SAVE"
        Me.MetroButton1.UseSelectable = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'MetroButton2
        '
        Me.MetroButton2.BackColor = System.Drawing.Color.Black
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.ForeColor = System.Drawing.Color.White
        Me.MetroButton2.Location = New System.Drawing.Point(348, -3)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(26, 24)
        Me.MetroButton2.TabIndex = 9
        Me.MetroButton2.Text = "X"
        Me.MetroButton2.UseSelectable = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 518)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.txtsl)
        Me.Controls.Add(Me.txtdbp)
        Me.Controls.Add(Me.txtdbu)
        Me.Controls.Add(Me.txtsapp)
        Me.Controls.Add(Me.txtsapu)
        Me.Controls.Add(Me.txtdn)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.txtServerType)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtServerType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtServer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtdn As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtsapu As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtsapp As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtdbu As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtdbp As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtsl As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
