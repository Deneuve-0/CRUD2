Imports System.Data.SqlClient

Public Class Form3
    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadOK.Click
        ' Verifica se os campos estão preenchidos
        If String.IsNullOrWhiteSpace(txtNomecad.Text) OrElse
           String.IsNullOrWhiteSpace(txtSenhacad.Text) Then
            MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' String de conexão - substitua pelos seus dados
            Dim connectionString As String = "Data Source=VIGOROTH-IV;Initial Catalog=CRUD;Integrated Security=True;TrustServerCertificate=True"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Inicia uma transação para garantir consistência
                Dim transaction As SqlTransaction = connection.BeginTransaction()

                Try
                    ' Primeiro, insere o usuário na tabela de login
                    Dim queryInserirUsuario As String = "INSERT INTO TABUSUARIO (USUARIO, SENHA) VALUES (@USUARIO, @SENHA)"

                    Using cmdInserirUsuario As New SqlCommand(queryInserirUsuario, connection, transaction)
                        cmdInserirUsuario.Parameters.AddWithValue("@USUARIO", txtNomecad.Text)
                        cmdInserirUsuario.Parameters.AddWithValue("@SENHA", txtSenhacad.Text)

                        cmdInserirUsuario.ExecuteNonQuery()
                    End Using

                    ' Depois, cria uma tabela com o nome do usuário
                    Dim nomeTabela As String = "TABELA_" & txtNomecad.Text.Replace(" ", "_")

                    Dim queryCriarTabela As String = $"CREATE TABLE {nomeTabela} (" &
                        "ID INT IDENTITY(1,1) PRIMARY KEY," &
                        "COMPROMISSO NVARCHAR(255)," &
                        "DESCRICAO NVARCHAR(255))"

                    Using cmdCriarTabela As New SqlCommand(queryCriarTabela, connection, transaction)
                        cmdCriarTabela.ExecuteNonQuery()
                    End Using

                    ' Confirma a transação
                    transaction.Commit()

                    MessageBox.Show($"Usuário cadastrado! Tabela {nomeTabela} criada.",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Limpa os campos após o cadastro
                    txtNomecad.Clear()
                    txtSenhacad.Clear()

                Catch ex As Exception
                    ' Reverte a transação em caso de erro
                    transaction.Rollback()
                    MessageBox.Show("Erro no cadastro: " & ex.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro de conexão: " & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Dim inicioForm As New Form1()
        inicioForm.Show()
        Me.Hide()
    End Sub
End Class