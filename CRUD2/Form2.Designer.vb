<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label4 = New Label()
        txtComp = New TextBox()
        txtDesc = New TextBox()
        btnLogOut = New Button()
        btnInserir = New Button()
        btnId = New Label()
        txtId = New TextBox()
        tblTabela = New DataGridView()
        btnAtualizar = New Button()
        btnDeletar = New Button()
        btnBuscar = New Button()
        CType(tblTabela, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F)
        Label2.Location = New Point(45, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 1
        Label2.Text = "Compromisso:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F)
        Label4.Location = New Point(45, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 20)
        Label4.TabIndex = 3
        Label4.Text = "Descrição:"
        ' 
        ' txtComp
        ' 
        txtComp.Location = New Point(155, 72)
        txtComp.Name = "txtComp"
        txtComp.Size = New Size(174, 23)
        txtComp.TabIndex = 5
        ' 
        ' txtDesc
        ' 
        txtDesc.Location = New Point(155, 114)
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(174, 23)
        txtDesc.TabIndex = 7
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Location = New Point(295, 171)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(75, 23)
        btnLogOut.TabIndex = 9
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnInserir
        ' 
        btnInserir.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnInserir.Location = New Point(47, 171)
        btnInserir.Name = "btnInserir"
        btnInserir.Size = New Size(75, 23)
        btnInserir.TabIndex = 10
        btnInserir.Text = "Inserir"
        btnInserir.UseVisualStyleBackColor = True
        ' 
        ' btnId
        ' 
        btnId.AutoSize = True
        btnId.Font = New Font("Segoe UI", 11.25F)
        btnId.Location = New Point(45, 31)
        btnId.Name = "btnId"
        btnId.Size = New Size(27, 20)
        btnId.TabIndex = 11
        btnId.Text = "ID:"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(155, 32)
        txtId.Name = "txtId"
        txtId.Size = New Size(89, 23)
        txtId.TabIndex = 12
        ' 
        ' tblTabela
        ' 
        tblTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tblTabela.Location = New Point(12, 250)
        tblTabela.Name = "tblTabela"
        tblTabela.Size = New Size(390, 150)
        tblTabela.TabIndex = 13
        ' 
        ' btnAtualizar
        ' 
        btnAtualizar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAtualizar.Location = New Point(128, 171)
        btnAtualizar.Name = "btnAtualizar"
        btnAtualizar.Size = New Size(75, 23)
        btnAtualizar.TabIndex = 14
        btnAtualizar.Text = "Atualizar"
        btnAtualizar.UseVisualStyleBackColor = True
        ' 
        ' btnDeletar
        ' 
        btnDeletar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDeletar.Location = New Point(209, 171)
        btnDeletar.Name = "btnDeletar"
        btnDeletar.Size = New Size(75, 23)
        btnDeletar.TabIndex = 15
        btnDeletar.Text = "Deletar"
        btnDeletar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.Location = New Point(254, 32)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 16
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(414, 426)
        Controls.Add(btnBuscar)
        Controls.Add(btnDeletar)
        Controls.Add(btnAtualizar)
        Controls.Add(tblTabela)
        Controls.Add(txtId)
        Controls.Add(btnId)
        Controls.Add(btnInserir)
        Controls.Add(btnLogOut)
        Controls.Add(txtDesc)
        Controls.Add(txtComp)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Compromissos"
        CType(tblTabela, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtComp As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnInserir As Button
    Friend WithEvents btnId As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents tblTabela As DataGridView
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnBuscar As Button
End Class
