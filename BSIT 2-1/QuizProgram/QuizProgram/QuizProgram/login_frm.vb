Imports System.Windows.Forms
Imports System.Data.Odbc

Public Class login_frm
    Dim mycmd As New OdbcCommand
    Dim readUser As OdbcDataReader
    Dim user As String
    Dim pass As String
    Dim Suser As String
    Dim Spass As String


    Private Sub cbshow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbshow.CheckedChanged
        If txtpass.UseSystemPasswordChar = False Then
            txtpass.UseSystemPasswordChar = True
        Else
            txtpass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtId.KeyDown
        If e.KeyCode = 13 Then
            If txtId.Text = "" Then
                MessageBox.Show("Enter User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtId.Focus()
            Else
                txtpass.Focus()
            End If
        End If
    End Sub

    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = 13 Then
            If txtpass.Text = "" Then
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtId.Focus()
            Else
                btn_login.Enabled = True
                btn_login.BackColor = Color.Lime
                btn_login.Focus()
            End If
        End If
    End Sub

    Private Sub login_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_login.Enabled = False
        btn_login.BackColor = Color.Silver
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        End
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click

        connect_me()

        user = txtId.Text.Trim
        pass = txtpass.Text.Trim
        Suser = txtId.Text.Trim
        Spass = txtpass.Text.Trim

        With mycmd
            .Connection = con
            .CommandText = "select * from acount_tbl where user = '" & user & "' and pass = '" & pass & "'"
            .ExecuteNonQuery()
        End With

        readUser = mycmd.ExecuteReader

        If readUser.HasRows Then
            readUser.Read()
            Dim main As New main_frm
            Me.Hide()
            main.Show()
        Else
            MessageBox.Show("User Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtId.Clear()
            txtpass.Clear()
            btn_login.Enabled = False
            btn_login.BackColor = Color.Silver
            txtId.Focus()
        End If

    End Sub
End Class
