Public Class stud_log_frm

    Private Sub cbshow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbshow.CheckedChanged
        If txtpass.UseSystemPasswordChar = False Then
            txtpass.UseSystemPasswordChar = True
        Else
            txtpass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtId.Text = "" Then
            MessageBox.Show("Please enter your username", "Security", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If txtpass.Text = "" Then
                MessageBox.Show("Please enter your password", "Security", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub
End Class