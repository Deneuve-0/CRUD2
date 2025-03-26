<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogin = New Button()
        btnCancelar = New Button()
        lblUsuario = New Label()
        lblSenha = New Label()
        txtUsuario = New TextBox()
        txtSenha = New TextBox()
        cbMostrarSenha = New CheckBox()
        btnCad = New Button()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(53, 131)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 32)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(174, 132)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 32)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Location = New Point(53, 47)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(50, 15)
        lblUsuario.TabIndex = 2
        lblUsuario.Text = "Usuario:"
        ' 
        ' lblSenha
        ' 
        lblSenha.AutoSize = True
        lblSenha.Location = New Point(53, 81)
        lblSenha.Name = "lblSenha"
        lblSenha.Size = New Size(42, 15)
        lblSenha.TabIndex = 3
        lblSenha.Text = "Senha:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(149, 44)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(100, 23)
        txtUsuario.TabIndex = 4
        ' 
        ' txtSenha
        ' 
        txtSenha.Location = New Point(149, 73)
        txtSenha.Name = "txtSenha"
        txtSenha.Size = New Size(100, 23)
        txtSenha.TabIndex = 5
        txtSenha.UseSystemPasswordChar = True
        ' 
        ' cbMostrarSenha
        ' 
        cbMostrarSenha.AutoSize = True
        cbMostrarSenha.Location = New Point(147, 106)
        cbMostrarSenha.Name = "cbMostrarSenha"
        cbMostrarSenha.Size = New Size(102, 19)
        cbMostrarSenha.TabIndex = 6
        cbMostrarSenha.Text = "Mostrar Senha"
        cbMostrarSenha.UseVisualStyleBackColor = True
        ' 
        ' btnCad
        ' 
        btnCad.Location = New Point(53, 169)
        btnCad.Name = "btnCad"
        btnCad.Size = New Size(196, 23)
        btnCad.TabIndex = 7
        btnCad.Text = "Cadastrar Usuario"
        btnCad.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(299, 205)
        Controls.Add(btnCad)
        Controls.Add(cbMostrarSenha)
        Controls.Add(txtSenha)
        Controls.Add(txtUsuario)
        Controls.Add(lblSenha)
        Controls.Add(lblUsuario)
        Controls.Add(btnCancelar)
        Controls.Add(btnLogin)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CRUD"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblSenha As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents cbMostrarSenha As CheckBox
    Friend WithEvents btnCad As Button

End Class
