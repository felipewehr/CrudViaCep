Public Class Cadastro

    Public CepId As Integer
    Dim conexao As New ConexaoDB

    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (CepId = 0) Then
            'Novo registro
            btnExcluir.Visible = False
        Else
            'Editando registro
            btnExcluir.Visible = True
        End If

    End Sub

    Private Sub btnBuscarCep_Click(sender As Object, e As EventArgs) Handles btnBuscarCep.Click

        Dim cep As String = txtCep.Text
        Dim viaCep As New ApiViaCep

        txtLogradouro.Text = viaCep.GetViaCep(cep, 1)
        txtBairro.Text = viaCep.GetViaCep(cep, 2)
        txtCidade.Text = viaCep.GetViaCep(cep, 3)
        txtUf.Text = viaCep.GetViaCep(cep, 4)
        txtComplemento.Text = viaCep.GetViaCep(cep, 5)
        txtCodIbge.Text = viaCep.GetViaCep(cep, 6)

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        conexao.DeletarCep(CepId)
        FecharCadastro()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If (CepId = 0) Then
            'Novo registro
            conexao.GravarCep(FormToCep())
        Else
            'Editando registro
            conexao.EditarCep(FormToCep())
        End If
        FecharCadastro()

    End Sub

    Private Function FormToCep() As Cep

        Dim cep As New Cep
        cep.CepId = CepId
        cep.Bairro = txtBairro.Text
        cep.Cep = txtCep.Text
        cep.Complemento = txtComplemento.Text
        cep.Estado = txtUf.Text
        cep.Ibge = txtCodIbge.Text
        cep.Localidade = txtCidade.Text
        cep.Logradouro = txtLogradouro.Text
        cep.Unidade = txtNumero.Text
        cep.Gia = txtCodGia.Text

        Return cep

    End Function


    Private Sub FecharCadastro()

        Close()

    End Sub
End Class
