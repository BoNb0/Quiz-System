Public Class q_frm
    'pag declare ng variable pra sa timespan'
    Dim Tspan As New TimeSpan

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'pag setup ng timespan'
        Tspan = Tspan.Subtract(New TimeSpan(0, 0, 1))
        lb_count.Text = String.Format("{0}:{1} ", Tspan.Minutes, Tspan.Seconds)
        'eto na ung countdown pag naubos na ung time
        If Tspan.Minutes = 0 AndAlso Tspan.Seconds = 0 Then
            Timer1.Stop()
            lb_count.Text = "00:00"
            lb_count.BackColor = Color.LightGray
            Timer1.Enabled = False
            p1.BackColor = Color.Silver
            MessageBox.Show("TIMES UP !", "TIMESUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            p1.Enabled = False
            'eto ung ginawa ko para maayos ung 00:00 format'
        ElseIf Tspan.Seconds < 10 Then
            lb_count.Text = String.Format("0{0}:0{1} ", Tspan.Minutes, Tspan.Seconds)
        ElseIf Tspan.Minutes < 10 Then
            lb_count.Text = String.Format("0{0}:{1} ", Tspan.Minutes, Tspan.Seconds)
        End If
        If Tspan.Minutes = 0 Then
            lb_count.ForeColor = Color.Red


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
            Timer1.Start()
        End If
    End Sub

    Private Sub q_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dito papalitan ung time (hour, CInt("Minutes"), Seconds)'
        Tspan = New TimeSpan(0, CInt("1"), 5)
        p1.Enabled = False
        btn_check.Enabled = False
        btn_check.BackColor = Color.Silver
        btn_finish.Enabled = False
        btn_finish.BackColor = Color.Silver

    End Sub


End Class
