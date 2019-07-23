<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listagem
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
        Me.ListCep = New System.Windows.Forms.ListView()
        Me.CepId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cep = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Logradouro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Complemento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Bairro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Localidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ibge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblListagem = New System.Windows.Forms.Label()
        Me.btnNovoCadastro = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListCep
        '
        Me.ListCep.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CepId, Me.Cep, Me.Logradouro, Me.Complemento, Me.Bairro, Me.Localidade, Me.Estado, Me.Unidade, Me.Ibge, Me.Gia})
        Me.ListCep.FullRowSelect = True
        Me.ListCep.GridLines = True
        Me.ListCep.Location = New System.Drawing.Point(17, 53)
        Me.ListCep.MultiSelect = False
        Me.ListCep.Name = "ListCep"
        Me.ListCep.Size = New System.Drawing.Size(964, 312)
        Me.ListCep.TabIndex = 0
        Me.ListCep.UseCompatibleStateImageBehavior = False
        Me.ListCep.View = System.Windows.Forms.View.Details
        '
        'CepId
        '
        Me.CepId.Text = "CepId"
        Me.CepId.Width = 50
        '
        'Cep
        '
        Me.Cep.Text = "Cep"
        Me.Cep.Width = 100
        '
        'Logradouro
        '
        Me.Logradouro.Text = "Logradouro"
        Me.Logradouro.Width = 100
        '
        'Complemento
        '
        Me.Complemento.Text = "Complemento"
        Me.Complemento.Width = 100
        '
        'Bairro
        '
        Me.Bairro.Text = "Bairro"
        Me.Bairro.Width = 100
        '
        'Localidade
        '
        Me.Localidade.Text = "Localidade"
        Me.Localidade.Width = 100
        '
        'Estado
        '
        Me.Estado.Text = "Estado"
        Me.Estado.Width = 100
        '
        'Unidade
        '
        Me.Unidade.Text = "Unidade"
        Me.Unidade.Width = 100
        '
        'Ibge
        '
        Me.Ibge.Text = "Ibge"
        Me.Ibge.Width = 100
        '
        'Gia
        '
        Me.Gia.Text = "Gia"
        Me.Gia.Width = 100
        '
        'lblListagem
        '
        Me.lblListagem.AutoSize = True
        Me.lblListagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListagem.Location = New System.Drawing.Point(10, 8)
        Me.lblListagem.Name = "lblListagem"
        Me.lblListagem.Size = New System.Drawing.Size(177, 42)
        Me.lblListagem.TabIndex = 1
        Me.lblListagem.Text = "Listagem"
        '
        'btnNovoCadastro
        '
        Me.btnNovoCadastro.Location = New System.Drawing.Point(879, 372)
        Me.btnNovoCadastro.Name = "btnNovoCadastro"
        Me.btnNovoCadastro.Size = New System.Drawing.Size(102, 23)
        Me.btnNovoCadastro.TabIndex = 2
        Me.btnNovoCadastro.Text = "Novo Cadastro"
        Me.btnNovoCadastro.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(798, 372)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Listagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 407)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNovoCadastro)
        Me.Controls.Add(Me.lblListagem)
        Me.Controls.Add(Me.ListCep)
        Me.MaximizeBox = False
        Me.Name = "Listagem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listagem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListCep As ListView
    Friend WithEvents lblListagem As Label
    Friend WithEvents btnNovoCadastro As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents CepId As ColumnHeader
    Friend WithEvents Cep As ColumnHeader
    Friend WithEvents Logradouro As ColumnHeader
    Friend WithEvents Complemento As ColumnHeader
    Friend WithEvents Bairro As ColumnHeader
    Friend WithEvents Localidade As ColumnHeader
    Friend WithEvents Estado As ColumnHeader
    Friend WithEvents Unidade As ColumnHeader
    Friend WithEvents Ibge As ColumnHeader
    Friend WithEvents Gia As ColumnHeader
End Class
