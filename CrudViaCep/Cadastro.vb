Public Class Cadastro

    Public CepId As Integer = 0

    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscarCep_Click(sender As Object, e As EventArgs) Handles btnBuscarCep.Click

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        FecharCadastro()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        FecharCadastro()

    End Sub

    Private Sub FecharCadastro()

        Close()

    End Sub
End Class
