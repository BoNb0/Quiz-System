Public Class blank_frm

    Private Sub Panel1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles Panel_blank.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel_blank.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_addq.Click
        Dim lb As New Label
        Dim tb As New TextBox

        Dim op1 As New Label
        Dim op1tb As New TextBox

        Dim op2 As New Label
        Dim op2tb As New TextBox

        Dim op3 As New Label
        Dim op3tb As New TextBox

        lb.Name = "lbq"
        lb.Text = "QUESTION:"
        lb.Font = New Font("Comic Sans MS", 11, FontStyle.Bold)
        lb.AutoSize = True
        lb.Location = New Point(74, 480)
        Panel_blank.Controls.Add(lb)

        tb.Name = "txt"
        tb.Font = New Font("Comic Sans MS", 11, FontStyle.Bold)
        tb.Size = New Size(637, 28)
        tb.Location = New Point(77, 505)
        Panel_blank.Controls.Add(tb)

        op1.Name = "op1"
        op1.Text = "A."
        op1.Font = New Font("Comic Sans MS", 11, FontStyle.Bold)
        op1.AutoSize = True
        op1.Location = New Point(73, 550)
        Panel_blank.Controls.Add(op1)

        op1tb.Name = "txt"
        op1tb.Font = New Font("Comic Sans MS", 11, FontStyle.Bold)
        op1tb.Size = New Size(182, 28)
        op1tb.Location = New Point(165, 545)
        Panel_blank.Controls.Add(op1tb)

        op2.Name = "op2"
        op2.Text = "B."
        op2.Font = New Font("Comic Sans MS", 11, FontStyle.Bold)
        op2.AutoSize = True
        op2.Location = New Point(73, 585)
        Panel_blank.Controls.Add(op2)

        op2tb.Name = "txt"
        op2tb.Font = New Font("Comic Sans MS", 11, FontStyle.Bold)
        op2tb.Size = New Size(182, 28)
        op2tb.Location = New Point(165, 580)
        Panel_blank.Controls.Add(op2tb)

        op3.Name = "OP3"
        op3.Text = "C."
        op3.Font = New Font("Comic Sans MS", 11, FontStyle.Bold)
        op3.AutoSize = True
        op3.Location = New Point(73, 620)
        Panel_blank.Controls.Add(op3)

        op3tb.Name = "txt"
        op3tb.Font = New Font("Comic Sans MS", 11, FontStyle.Bold)
        op3tb.Size = New Size(182, 28)
        op3tb.Location = New Point(165, 615)
        Panel_blank.Controls.Add(op3tb)

        MessageBox.Show("Add Success !", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        op3.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_blank.Click

        Dim response As Integer

        response = MessageBox.Show("All you'r input will be deleted !", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If response = vbOK Then
            Me.Hide()
            main_frm.Show()

        End If
    End Sub

    Private Sub txt_desc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_desc.KeyDown
        If e.KeyCode = 13 Then
            If txt_desc.Text = "" Then
                MessageBox.Show("Enter Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_desc.Focus()
            Else
                txt_q.Focus()
            End If
        End If
    End Sub

    Private Sub txt_sub_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sub.KeyDown
        If e.KeyCode = 13 Then
            If txt_sub.Text = "" Then
                MessageBox.Show("Enter Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_sub.Focus()
            Else
                txt_desc.Focus()
            End If
        End If
    End Sub
End Class
