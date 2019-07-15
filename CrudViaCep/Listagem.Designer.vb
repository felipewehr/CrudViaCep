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
        Me.listCep = New System.Windows.Forms.ListView()
        Me.lblListagem = New System.Windows.Forms.Label()
        Me.btnNovoCadastro = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listCep
        '
        Me.listCep.FullRowSelect = True
        Me.listCep.GridLines = True
        Me.listCep.Location = New System.Drawing.Point(17, 53)
        Me.listCep.MultiSelect = False
        Me.listCep.Name = "listCep"
        Me.listCep.Size = New System.Drawing.Size(964, 312)
        Me.listCep.TabIndex = 0
        Me.listCep.UseCompatibleStateImageBehavior = False
        Me.listCep.View = System.Windows.Forms.View.Details
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
        Me.Controls.Add(Me.listCep)
        Me.MaximizeBox = False
        Me.Name = "Listagem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listagem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listCep As ListView
    Friend WithEvents lblListagem As Label
    Friend WithEvents btnNovoCadastro As Button
    Friend WithEvents btnEditar As Button
End Class
