<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_frm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_frm))
        Me.lb_form = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_resp = New System.Windows.Forms.Button
        Me.btn_form = New System.Windows.Forms.Button
        Me.btn_blank = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.panel_main = New System.Windows.Forms.Panel
        Me.lb_make = New System.Windows.Forms.Label
        Me.tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_exit = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.MenuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DarkModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LihtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BlankBttonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.panel_main.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_form
        '
        Me.lb_form.AutoSize = True
        Me.lb_form.BackColor = System.Drawing.Color.Transparent
        Me.lb_form.Cursor = System.Windows.Forms.Cursors.Default
        Me.lb_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_form.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_form.ForeColor = System.Drawing.Color.Black
        Me.lb_form.Location = New System.Drawing.Point(83, 70)
        Me.lb_form.Name = "lb_form"
        Me.lb_form.Size = New System.Drawing.Size(94, 38)
        Me.lb_form.TabIndex = 0
        Me.lb_form.Text = "Forms"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.btn_resp)
        Me.GroupBox1.Controls.Add(Me.btn_form)
        Me.GroupBox1.Controls.Add(Me.btn_blank)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(67, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 281)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Start"
        '
        'btn_resp
        '
        Me.btn_resp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_resp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_resp.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_resp.Location = New System.Drawing.Point(608, 197)
        Me.btn_resp.Name = "btn_resp"
        Me.btn_resp.Size = New System.Drawing.Size(131, 39)
        Me.btn_resp.TabIndex = 1
        Me.btn_resp.Text = "Responses"
        Me.tip.SetToolTip(Me.btn_resp, "Who answered" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btn_resp.UseVisualStyleBackColor = True
        '
        'btn_form
        '
        Me.btn_form.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_form.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_form.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_form.Location = New System.Drawing.Point(350, 197)
        Me.btn_form.Name = "btn_form"
        Me.btn_form.Size = New System.Drawing.Size(131, 39)
        Me.btn_form.TabIndex = 1
        Me.btn_form.Text = "Form"
        Me.tip.SetToolTip(Me.btn_form, "See you'r Recent Quiz")
        Me.btn_form.UseVisualStyleBackColor = True
        '
        'btn_blank
        '
        Me.btn_blank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_blank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_blank.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_blank.Location = New System.Drawing.Point(74, 197)
        Me.btn_blank.Name = "btn_blank"
        Me.btn_blank.Size = New System.Drawing.Size(131, 39)
        Me.btn_blank.TabIndex = 1
        Me.btn_blank.Text = "Blank"
        Me.tip.SetToolTip(Me.btn_blank, "This form is limited to 15 Question and Multiple Choice only" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btn_blank.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.MenuToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(12, 4)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'panel_main
        '
        Me.panel_main.BackColor = System.Drawing.Color.White
        Me.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_main.Controls.Add(Me.btn_exit)
        Me.panel_main.Controls.Add(Me.lb_make)
        Me.panel_main.Controls.Add(Me.Panel1)
        Me.panel_main.Controls.Add(Me.GroupBox1)
        Me.panel_main.Controls.Add(Me.lb_form)
        Me.panel_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_main.ForeColor = System.Drawing.Color.White
        Me.panel_main.Location = New System.Drawing.Point(0, 28)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Size = New System.Drawing.Size(965, 533)
        Me.panel_main.TabIndex = 4
        '
        'lb_make
        '
        Me.lb_make.AutoSize = True
        Me.lb_make.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_make.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lb_make.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_make.ForeColor = System.Drawing.Color.Black
        Me.lb_make.Location = New System.Drawing.Point(291, 24)
        Me.lb_make.Name = "lb_make"
        Me.lb_make.Size = New System.Drawing.Size(453, 40)
        Me.lb_make.TabIndex = 5
        Me.lb_make.Text = "MAKE A SIMPLE QUIZ FOR YOU"
        '
        'btn_exit
        '
        Me.btn_exit.BackgroundImage = Global.QuizProgram.My.Resources.Resources.log_out_icon_icons_com_50106
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Red
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_exit.Location = New System.Drawing.Point(828, 467)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(61, 44)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BackgroundImage = Global.QuizProgram.My.Resources.Resources.file_form_icon_245983
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(27, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(48, 58)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Panel2.Location = New System.Drawing.Point(40, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(8, 8)
        Me.Panel2.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.QuizProgram.My.Resources.Resources.Response
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Location = New System.Drawing.Point(608, 76)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(131, 115)
        Me.Panel5.TabIndex = 2
        Me.tip.SetToolTip(Me.Panel5, "Who answered")
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.QuizProgram.My.Resources.Resources.reading_mode_mobile_regular_icon_203340
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(350, 76)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(131, 115)
        Me.Panel4.TabIndex = 2
        Me.tip.SetToolTip(Me.Panel4, "See you'r Recent Quiz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.QuizProgram.My.Resources.Resources.plus_circle_icon_icons_com_66720
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(74, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(131, 115)
        Me.Panel3.TabIndex = 0
        Me.tip.SetToolTip(Me.Panel3, "This form is limited to 15 Question and Multiple Choice only")
        '
        'MenuToolStripMenuItem1
        '
        Me.MenuToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuToolStripMenuItem1.Image = Global.QuizProgram.My.Resources.Resources.Menu_icon_icon_icons_com_71858
        Me.MenuToolStripMenuItem1.Name = "MenuToolStripMenuItem1"
        Me.MenuToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.MenuToolStripMenuItem1.Text = "Menu"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarkModeToolStripMenuItem, Me.LihtToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'DarkModeToolStripMenuItem
        '
        Me.DarkModeToolStripMenuItem.Image = Global.QuizProgram.My.Resources.Resources.reading_mode_mobile_filled_icon_201248
        Me.DarkModeToolStripMenuItem.Name = "DarkModeToolStripMenuItem"
        Me.DarkModeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.DarkModeToolStripMenuItem.Text = "Dark mode"
        '
        'LihtToolStripMenuItem
        '
        Me.LihtToolStripMenuItem.Image = Global.QuizProgram.My.Resources.Resources.reading_mode_mobile_regular_icon_203340
        Me.LihtToolStripMenuItem.Name = "LihtToolStripMenuItem"
        Me.LihtToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.LihtToolStripMenuItem.Text = "Ligth mode"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlankBttonToolStripMenuItem})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'BlankBttonToolStripMenuItem
        '
        Me.BlankBttonToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BlankBttonToolStripMenuItem.Image = Global.QuizProgram.My.Resources.Resources.infoflat_105980
        Me.BlankBttonToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BlankBttonToolStripMenuItem.Name = "BlankBttonToolStripMenuItem"
        Me.BlankBttonToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.BlankBttonToolStripMenuItem.Text = "Blank button"
        '
        'main_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(965, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel_main)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAIN"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panel_main.ResumeLayout(False)
        Me.panel_main.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_form As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_blank As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DarkModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panel_main As System.Windows.Forms.Panel
    Friend WithEvents lb_make As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_form As System.Windows.Forms.Button
    Friend WithEvents tip As System.Windows.Forms.ToolTip
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btn_resp As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents BlankBttonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
