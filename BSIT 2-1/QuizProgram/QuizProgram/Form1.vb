Public Class q_frm

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        If lb_count.Text = 11 Then
            lb_count.ForeColor = Color.Red
            lb_count.Text = Val(lb_count.Text) - 1
        ElseIf lb_count.Text = 0 Then
            Timer1.Enabled = False
            p1.BackColor = Color.Silver
            MessageBox.Show("TIMES UP !", "TIMESUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            p1.Enabled = False

            btn_check.Enabled = True
            btn_check.BackColor = Color.Lime

            btn_finish.Enabled = False
            btn_finish.BackColor = Color.Silver
        Else
            lb_count.Text = Val(lb_count.Text) - 1

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click
        p1.Enabled = True

        btn_start.Enabled = False
        btn_start.BackColor = Color.Silver

        btn_finish.Enabled = True
        btn_finish.BackColor = Color.SteelBlue

        If Timer1.Enabled = True Then
            Timer1.Start()
        Else
            lb_count.Text = 15
            Timer1.Start()
        End If
    End Sub

    Private Sub q_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        p1.Enabled = False
        btn_check.Enabled = False
        btn_check.BackColor = Color.Silver
        btn_finish.Enabled = False
        btn_finish.BackColor = Color.Silver

    End Sub
End Class
