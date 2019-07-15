<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
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
        Me.lblCep = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.btnBuscarCep = New System.Windows.Forms.Button()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodIbge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUf = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodGia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(50, 15)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(28, 13)
        Me.lblCep.TabIndex = 0
        Me.lblCep.Text = "CEP"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(84, 12)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(100, 20)
        Me.txtCep.TabIndex = 0
        '
        'btnBuscarCep
        '
        Me.btnBuscarCep.Location = New System.Drawing.Point(190, 10)
        Me.btnBuscarCep.Name = "btnBuscarCep"
        Me.btnBuscarCep.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCep.TabIndex = 1
        Me.btnBuscarCep.Text = "Buscar CEP"
        Me.btnBuscarCep.UseVisualStyleBackColor = True
        '
        'lblLogradouro
        '
        Me.lblLogradouro.AutoSize = True
        Me.lblLogradouro.Location = New System.Drawing.Point(17, 41)
        Me.lblLogradouro.Name = "lblLogradouro"
        Me.lblLogradouro.Size = New System.Drawing.Size(61, 13)
        Me.lblLogradouro.TabIndex = 0
        Me.lblLogradouro.Text = "Logradouro"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(84, 38)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(313, 20)
        Me.txtLogradouro.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod. IBGE"
        '
        'txtCodIbge
        '
        Me.txtCodIbge.Location = New System.Drawing.Point(84, 169)
        Me.txtCodIbge.Name = "txtCodIbge"
        Me.txtCodIbge.Size = New System.Drawing.Size(128, 20)
        Me.txtCodIbge.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cidade"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(84, 64)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(313, 20)
        Me.txtCidade.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "UF"
        '
        'txtUf
        '
        Me.txtUf.Location = New System.Drawing.Point(84, 90)
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(46, 20)
        Me.txtUf.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "N. Residencial"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(84, 143)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(46, 20)
        Me.txtNumero.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Bairro"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(84, 117)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(46, 20)
        Me.txtBairro.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cod. GIA"
        '
        'txtCodGia
        '
        Me.txtCodGia.Location = New System.Drawing.Point(84, 195)
        Me.txtCodGia.Name = "txtCodGia"
        Me.txtCodGia.Size = New System.Drawing.Size(128, 20)
        Me.txtCodGia.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Complemento"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(84, 221)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(313, 20)
        Me.txtComplemento.TabIndex = 9
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(322, 247)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 11
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(241, 247)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 10
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 277)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnBuscarCep)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtComplemento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodGia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodIbge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLogradouro)
        Me.Controls.Add(Me.lblLogradouro)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.lblCep)
        Me.MaximizeBox = False
        Me.Name = "Cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCep As Label
    Public WithEvents txtCep As TextBox
    Friend WithEvents btnBuscarCep As Button
    Friend WithEvents lblLogradouro As Label
    Public WithEvents txtLogradouro As TextBox
    Friend WithEvents Label1 As Label
    Public WithEvents txtCodIbge As TextBox
    Friend WithEvents Label2 As Label
    Public WithEvents txtCidade As TextBox
    Friend WithEvents Label3 As Label
    Public WithEvents txtUf As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents txtNumero As TextBox
    Friend WithEvents Label5 As Label
    Public WithEvents txtBairro As TextBox
    Friend WithEvents Label6 As Label
    Public WithEvents txtCodGia As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents txtComplemento As TextBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
End Class
