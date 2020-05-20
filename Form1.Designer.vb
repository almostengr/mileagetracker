<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.StartMileage_TextBox = New System.Windows.Forms.TextBox
        Me.StartMileage_Label = New System.Windows.Forms.Label
        Me.EndMileage_Label = New System.Windows.Forms.Label
        Me.EndMilage_TextBox = New System.Windows.Forms.TextBox
        Me.Save_Button = New System.Windows.Forms.Button
        Me.Date_Label = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Reset_Button = New System.Windows.Forms.Button
        Me.AvgMpg_Label = New System.Windows.Forms.Label
        Me.AvgMpg_TextBox = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Stats_GroupBox = New System.Windows.Forms.GroupBox
        Me.URL_LinkLabel = New System.Windows.Forms.LinkLabel
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartMileage_TextBox
        '
        Me.StartMileage_TextBox.Location = New System.Drawing.Point(35, 117)
        Me.StartMileage_TextBox.Name = "StartMileage_TextBox"
        Me.StartMileage_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.StartMileage_TextBox.TabIndex = 0
        '
        'StartMileage_Label
        '
        Me.StartMileage_Label.AutoSize = True
        Me.StartMileage_Label.Location = New System.Drawing.Point(32, 101)
        Me.StartMileage_Label.Name = "StartMileage_Label"
        Me.StartMileage_Label.Size = New System.Drawing.Size(69, 13)
        Me.StartMileage_Label.TabIndex = 1
        Me.StartMileage_Label.Text = "Start Mileage"
        '
        'EndMileage_Label
        '
        Me.EndMileage_Label.AutoSize = True
        Me.EndMileage_Label.Location = New System.Drawing.Point(32, 142)
        Me.EndMileage_Label.Name = "EndMileage_Label"
        Me.EndMileage_Label.Size = New System.Drawing.Size(66, 13)
        Me.EndMileage_Label.TabIndex = 2
        Me.EndMileage_Label.Text = "End Mileage"
        '
        'EndMilage_TextBox
        '
        Me.EndMilage_TextBox.Location = New System.Drawing.Point(35, 158)
        Me.EndMilage_TextBox.Name = "EndMilage_TextBox"
        Me.EndMilage_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.EndMilage_TextBox.TabIndex = 3
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(11, 226)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(75, 23)
        Me.Save_Button.TabIndex = 6
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'Date_Label
        '
        Me.Date_Label.AutoSize = True
        Me.Date_Label.Location = New System.Drawing.Point(32, 57)
        Me.Date_Label.Name = "Date_Label"
        Me.Date_Label.Size = New System.Drawing.Size(30, 13)
        Me.Date_Label.TabIndex = 7
        Me.Date_Label.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(35, 74)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Reset_Button
        '
        Me.Reset_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Reset_Button.Location = New System.Drawing.Point(92, 226)
        Me.Reset_Button.Name = "Reset_Button"
        Me.Reset_Button.Size = New System.Drawing.Size(75, 23)
        Me.Reset_Button.TabIndex = 9
        Me.Reset_Button.Text = "Reset"
        Me.Reset_Button.UseVisualStyleBackColor = True
        '
        'AvgMpg_Label
        '
        Me.AvgMpg_Label.AutoSize = True
        Me.AvgMpg_Label.Location = New System.Drawing.Point(32, 185)
        Me.AvgMpg_Label.Name = "AvgMpg_Label"
        Me.AvgMpg_Label.Size = New System.Drawing.Size(74, 13)
        Me.AvgMpg_Label.TabIndex = 10
        Me.AvgMpg_Label.Text = "Average MPG"
        '
        'AvgMpg_TextBox
        '
        Me.AvgMpg_TextBox.Location = New System.Drawing.Point(35, 200)
        Me.AvgMpg_TextBox.Name = "AvgMpg_TextBox"
        Me.AvgMpg_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.AvgMpg_TextBox.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(505, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportLocationToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ExportLocationToolStripMenuItem
        '
        Me.ExportLocationToolStripMenuItem.Name = "ExportLocationToolStripMenuItem"
        Me.ExportLocationToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ExportLocationToolStripMenuItem.Text = "Export Location"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Stats_GroupBox
        '
        Me.Stats_GroupBox.Location = New System.Drawing.Point(194, 41)
        Me.Stats_GroupBox.Name = "Stats_GroupBox"
        Me.Stats_GroupBox.Size = New System.Drawing.Size(284, 235)
        Me.Stats_GroupBox.TabIndex = 13
        Me.Stats_GroupBox.TabStop = False
        Me.Stats_GroupBox.Text = "Statistics"
        '
        'URL_LinkLabel
        '
        Me.URL_LinkLabel.AutoSize = True
        Me.URL_LinkLabel.Location = New System.Drawing.Point(138, 305)
        Me.URL_LinkLabel.Name = "URL_LinkLabel"
        Me.URL_LinkLabel.Size = New System.Drawing.Size(117, 13)
        Me.URL_LinkLabel.TabIndex = 14
        Me.URL_LinkLabel.TabStop = True
        Me.URL_LinkLabel.Text = "KR Computing Website"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 330)
        Me.Controls.Add(Me.URL_LinkLabel)
        Me.Controls.Add(Me.Stats_GroupBox)
        Me.Controls.Add(Me.AvgMpg_TextBox)
        Me.Controls.Add(Me.AvgMpg_Label)
        Me.Controls.Add(Me.Reset_Button)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Date_Label)
        Me.Controls.Add(Me.Save_Button)
        Me.Controls.Add(Me.EndMilage_TextBox)
        Me.Controls.Add(Me.EndMileage_Label)
        Me.Controls.Add(Me.StartMileage_Label)
        Me.Controls.Add(Me.StartMileage_TextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Tha Ram Mileage Tracker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartMileage_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartMileage_Label As System.Windows.Forms.Label
    Friend WithEvents EndMileage_Label As System.Windows.Forms.Label
    Friend WithEvents EndMilage_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Save_Button As System.Windows.Forms.Button
    Friend WithEvents Date_Label As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Reset_Button As System.Windows.Forms.Button
    Friend WithEvents AvgMpg_Label As System.Windows.Forms.Label
    Friend WithEvents AvgMpg_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Stats_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents URL_LinkLabel As System.Windows.Forms.LinkLabel

End Class
