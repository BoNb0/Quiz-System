Public Class main_frm

    Private Sub DarkModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DarkModeToolStripMenuItem.Click
        panel_main.BackColor = Color.Black
        lb_form.ForeColor = Color.White
        lb_make.ForeColor = Color.White
    End Sub

    Private Sub LihtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LihtToolStripMenuItem.Click
        panel_main.BackColor = Color.White
        lb_form.ForeColor = Color.Black
        lb_make.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_blank.Click
        blank_frm.Show()
        blank_frm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub BlankBttonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlankBttonToolStripMenuItem.Click
        MessageBox.Show("This form is limited to 15 Question and Multiple Choice only", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_form_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_form.Click
        MessageBox.Show("This Feture ia under construction", "info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class
