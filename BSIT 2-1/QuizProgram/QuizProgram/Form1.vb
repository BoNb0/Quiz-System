Public Class q_frm
    'Gumamit ako ng timespan'
    Dim Tspan As New TimeSpan 

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Tspan = Tspan.Subtract(New TimeSpan(0, 0, 1))
        lb_count.Text = String.Format("{0}:{1} ", Tspan.Minutes, Tspan.Seconds)
        If Tspan.Minutes = 0 AndAlso Tspan.Seconds = 0 Then
            Timer1.Stop()
            lb_count.Text = "00:00"

            Timer1.Enabled = False
            p1.BackColor = Color.Silver
            MessageBox.Show("TIMES UP !", "TIMESUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            p1.Enabled = False
            
            'Eto ung solution ko para format nya ay 00:00'
        ElseIf Tspan.Minutes <> 10 Then
            lb_count.Text = String.Format("0{0}:{01} ", Tspan.Minutes, Tspan.Seconds)
        ElseIf Tspan.Seconds = 10 Then
            lb_count.Text = String.Format("0{0}:0{01} ", Tspan.Minutes, Tspan.Seconds)
        End If

    End Sub
    'bale ung iba iniwan ko lang'
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
        'Tspan = New TimeSpan(Hour, CInt("Minutes"), Seconds) Dyan currently napapalitan'
        Tspan = New TimeSpan(0, CInt("5"), 20)
        p1.Enabled = False
        btn_check.Enabled = False
        btn_check.BackColor = Color.Silver
        btn_finish.Enabled = False
        btn_finish.BackColor = Color.Silver

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub lb_count_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_count.Click

    End Sub
End Class
