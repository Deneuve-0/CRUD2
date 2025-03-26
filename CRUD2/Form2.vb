Imports System.Data.SqlClient


Public Class Form2

    Dim con As New SqlConnection("Data Source=VIGOROTH-IV;Initial Catalog=CRUD;Integrated Security=True;TrustServerCertificate=True")
    Dim nome As String = Form1.txtUsuario.Text

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click


        Dim id As Integer = txtId.Text
        Dim comp = txtComp.Text
        Dim desc = txtDesc.Text



        con.Open()
        Dim setIdentityInsertOn As New SqlCommand($"SET IDENTITY_INSERT TABELA_{nome} ON", con)
        setIdentityInsertOn.ExecuteNonQuery()
        Dim command As New SqlCommand($"Insert into TABELA_{nome} (id, compromisso, [descricao]) values(@ID, @COMPROMISSO, @DESCRICAO)", con)
        command.Parameters.AddWithValue("@ID", id)
        command.Parameters.AddWithValue("@COMPROMISSO", comp)
        command.Parameters.AddWithValue("@DESCRICAO", desc)
        command.ExecuteNonQuery()
        Dim setIdentityInsertOff As New SqlCommand($"SET IDENTITY_INSERT TABELA_{nome} OFF", con)
        setIdentityInsertOff.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Inserido com Sucesso")
        LoadDataInGrid()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim inicioForm As New Form1()
        inicioForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand($"SELECT * FROM TABELA_{nome}", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        tblTabela.DataSource = dt
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Dim id As Integer = txtId.Text
        Dim comp = txtComp.Text
        Dim desc = txtDesc.Text



        con.Open()
        Dim setIdentityInsertOn As New SqlCommand($"SET IDENTITY_INSERT TABELA_{nome} ON", con)
        setIdentityInsertOn.ExecuteNonQuery()
        Dim command As New SqlCommand($"UPDATE TABELA_{nome} SET COMPROMISSO = '" & comp & "', DESCRICAO = '" & desc & "' WHERE ID = '" & id & "' ", con)
        command.Parameters.AddWithValue("@ID", id)
        command.Parameters.AddWithValue("@COMPROMISSO", comp)
        command.Parameters.AddWithValue("@DESCRICAO", desc)
        command.ExecuteNonQuery()
        Dim setIdentityInsertOff As New SqlCommand($"SET IDENTITY_INSERT TABELA_{nome} OFF", con)
        setIdentityInsertOff.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Atualizado com Sucesso")
        LoadDataInGrid()
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        con.Open()
        Dim command As New SqlCommand($"DELETE FROM TABELA_{nome} WHERE ID = '" & txtId.Text & "' ", con)
        command.ExecuteNonQuery()
        MessageBox.Show("Deletado com Sucesso")
        LoadDataInGrid()
        con.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim command As New SqlCommand($"SELECT * FROM TABELA_{nome} WHERE ID = '" & txtId.Text & "' ", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        tblTabela.DataSource = dt

    End Sub
End Class