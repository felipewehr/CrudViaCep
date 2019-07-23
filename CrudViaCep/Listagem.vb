Public Class Listagem

    Dim index As Integer

    Private Sub Listagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarListCep()

    End Sub

    Private Sub btnNovoCadastro_Click(sender As Object, e As EventArgs) Handles btnNovoCadastro.Click

        Dim cadastro As New Cadastro
        cadastro.ShowDialog()
        CarregarListCep()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If ListCep.SelectedItems.Count = 1 Then
            Dim cadastro As New Cadastro
            cadastro.CepId = Integer.Parse(ListCep.Items(index).Text)
            cadastro.txtCep.Text = ListCep.Items(index).SubItems(1).Text
            cadastro.txtLogradouro.Text = ListCep.Items(index).SubItems(2).Text
            cadastro.txtComplemento.Text = ListCep.Items(index).SubItems(3).Text
            cadastro.txtBairro.Text = ListCep.Items(index).SubItems(4).Text
            cadastro.txtCidade.Text = ListCep.Items(index).SubItems(5).Text
            cadastro.txtUf.Text = ListCep.Items(index).SubItems(6).Text
            cadastro.txtNumero.Text = ListCep.Items(index).SubItems(7).Text
            cadastro.txtCodIbge.Text = ListCep.Items(index).SubItems(8).Text
            cadastro.txtCodGia.Text = ListCep.Items(index).SubItems(9).Text

            cadastro.ShowDialog()
            CarregarListCep()
        End If

    End Sub

    Private Sub CarregarListCep()

        ListCep.Items.Clear()

        Dim objDados As New ConexaoDB()
        Dim dt As New DataTable
        dt = objDados.BuscarCep()

        For Each linha As DataRow In dt.Rows
            Dim lista As New ListViewItem
            lista.Text = linha("CepId").ToString()
            lista.SubItems.Add(linha("Cep").ToString())
            lista.SubItems.Add(linha("Logradouro").ToString())
            lista.SubItems.Add(linha("Complemento").ToString())
            lista.SubItems.Add(linha("Bairro").ToString())
            lista.SubItems.Add(linha("Localidade").ToString())
            lista.SubItems.Add(linha("Estado").ToString())
            lista.SubItems.Add(linha("Unidade").ToString())
            lista.SubItems.Add(linha("Ibge").ToString())
            lista.SubItems.Add(linha("Gia").ToString())

            ListCep.Items.Add(lista)
        Next

    End Sub

    Private Sub ListCep_Click(sender As Object, e As EventArgs) Handles ListCep.Click

        If ListCep.SelectedItems.Count = 1 Then
            index = ListCep.SelectedItems(0).Index
        End If

    End Sub
End Class