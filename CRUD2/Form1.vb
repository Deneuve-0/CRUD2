Imports System.Data.SqlClient
Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As New SqlConnection("Data Source=VIGOROTH-IV;Initial Catalog=CRUD;Integrated Security=True;TrustServerCertificate=True")
        con.Open()
        Dim query As String = "SELECT COUNT(*) FROM TABUSUARIO WHERE USUARIO=@USUARIO AND SENHA=@SENHA"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@USUARIO", txtUsuario.Text)
        cmd.Parameters.AddWithValue("@SENHA", txtSenha.Text)
        Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar)
        con.Close()
        If count > 0 Then
            MessageBox.Show("Login realizado", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim proximoForm As New Form2()
            proximoForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Erro no Login")
        End If
    End Sub
    Private Sub cbMostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles cbMostrarSenha.CheckedChanged
        txtSenha.UseSystemPasswordChar = Not cbMostrarSenha.Checked
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnCad_Click(sender As Object, e As EventArgs) Handles btnCad.Click
        Dim cadastroForm As New Form3()
        cadastroForm.Show()
        Me.Hide()
    End Sub
End Class