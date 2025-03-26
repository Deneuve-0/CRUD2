<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        txtNomecad = New TextBox()
        txtSenhacad = New TextBox()
        btnCadOK = New Button()
        btnVoltar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nome:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 1
        Label2.Text = "Senha:"
        ' 
        ' txtNomecad
        ' 
        txtNomecad.Location = New Point(140, 40)
        txtNomecad.Name = "txtNomecad"
        txtNomecad.Size = New Size(100, 23)
        txtNomecad.TabIndex = 2
        ' 
        ' txtSenhacad
        ' 
        txtSenhacad.Location = New Point(140, 68)
        txtSenhacad.Name = "txtSenhacad"
        txtSenhacad.Size = New Size(100, 23)
        txtSenhacad.TabIndex = 3
        ' 
        ' btnCadOK
        ' 
        btnCadOK.Location = New Point(33, 112)
        btnCadOK.Name = "btnCadOK"
        btnCadOK.Size = New Size(75, 23)
        btnCadOK.TabIndex = 4
        btnCadOK.Text = "Cadastrar"
        btnCadOK.UseVisualStyleBackColor = True
        ' 
        ' btnVoltar
        ' 
        btnVoltar.Location = New Point(165, 112)
        btnVoltar.Name = "btnVoltar"
        btnVoltar.Size = New Size(75, 23)
        btnVoltar.TabIndex = 5
        btnVoltar.Text = "Voltar"
        btnVoltar.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(267, 163)
        Controls.Add(btnVoltar)
        Controls.Add(btnCadOK)
        Controls.Add(txtSenhacad)
        Controls.Add(txtNomecad)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cadastrar Usuário"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomecad As TextBox
    Friend WithEvents txtSenhacad As TextBox
    Friend WithEvents btnCadOK As Button
    Friend WithEvents btnVoltar As Button
End Class
