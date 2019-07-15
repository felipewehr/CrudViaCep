Public Class Listagem
    Private Sub Listagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNovoCadastro_Click(sender As Object, e As EventArgs) Handles btnNovoCadastro.Click

        AbrirCadastro()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        AbrirCadastro()

    End Sub

    Private Sub AbrirCadastro()

        Dim cadastro As New Cadastro
        cadastro.ShowDialog()

    End Sub
End Class