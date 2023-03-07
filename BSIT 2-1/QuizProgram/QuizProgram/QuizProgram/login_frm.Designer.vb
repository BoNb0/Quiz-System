<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_frm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtpass = New System.Windows.Forms.TextBox
        Me.btn_login = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.cbshow = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(178, 51)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(179, 28)
        Me.txtId.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(178, 97)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(179, 28)
        Me.txtpass.TabIndex = 4
        Me.txtpass.UseSystemPasswordChar = True
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Lime
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(293, 140)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(64, 33)
        Me.btn_login.TabIndex = 6
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Tomato
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(223, 140)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_cancel.Size = New System.Drawing.Size(64, 33)
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'cbshow
        '
        Me.cbshow.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbshow.AutoSize = True
        Me.cbshow.BackgroundImage = Global.QuizProgram.My.Resources.Resources._3844441_eye_see_show_view_watch_110305
        Me.cbshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cbshow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbshow.Location = New System.Drawing.Point(363, 105)
        Me.cbshow.Name = "cbshow"
        Me.cbshow.Size = New System.Drawing.Size(20, 17)
        Me.cbshow.TabIndex = 5
        Me.cbshow.Text = "   "
        Me.cbshow.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.QuizProgram.My.Resources.Resources.user
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(12, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 149)
        Me.Panel1.TabIndex = 0
        '
        'login_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 198)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbshow)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents cbshow As System.Windows.Forms.CheckBox
End Class
