Imports System.Data.SqlClient

Public Class ConexaoDB

    Public Const strConexao As String = "Data Source=ANDRE\SQLEXPRESS;Initial Catalog=CrudViaCep;Integrated Security=True"
    Public strInstrucao As String = String.Empty
    Public objConexao As New SqlConnection(strConexao)
    Public objCommand As New SqlCommand(strInstrucao, objConexao)

    Public Sub GravarCep(ByVal cep As Cep)

        strInstrucao = "INSERT INTO Cep VALUES (@Cep, @Logradouro, @Complemento, @Bairro, @Localidade, @Estado, @Unidade, @Ibge, @Gia)"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Cep", cep.Cep)
        objCommand.Parameters.AddWithValue("@Logradouro", cep.Logradouro)
        objCommand.Parameters.AddWithValue("@Complemento", cep.Complemento)
        objCommand.Parameters.AddWithValue("@Bairro", cep.Bairro)
        objCommand.Parameters.AddWithValue("@Localidade", cep.Localidade)
        objCommand.Parameters.AddWithValue("@Estado", cep.Estado)
        objCommand.Parameters.AddWithValue("@Unidade", cep.Unidade)
        objCommand.Parameters.AddWithValue("@Ibge", cep.Ibge)
        objCommand.Parameters.AddWithValue("@Gia", cep.Gia)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub

    Public Sub EditarCep(ByVal cep As Cep)

        strInstrucao = "UPDATE Cep SET Cep = @Cep, Logradouro = @Logradouro, Complemento = @Complemento, Bairro = @Bairro, Localidade = @Localidade, Estado = @Estado, Unidade = @Unidade, Ibge = @Ibge, Gia = @Gia WHERE CepId = @CepId"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Cep", cep.Cep)
        objCommand.Parameters.AddWithValue("@Logradouro", cep.Logradouro)
        objCommand.Parameters.AddWithValue("@Complemento", cep.Complemento)
        objCommand.Parameters.AddWithValue("@Bairro", cep.Bairro)
        objCommand.Parameters.AddWithValue("@Localidade", cep.Localidade)
        objCommand.Parameters.AddWithValue("@Estado", cep.Estado)
        objCommand.Parameters.AddWithValue("@Unidade", cep.Unidade)
        objCommand.Parameters.AddWithValue("@Ibge", cep.Ibge)
        objCommand.Parameters.AddWithValue("@Gia", cep.Gia)
        objCommand.Parameters.AddWithValue("@CepId", cep.CepId)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub

    Public Sub DeletarCep(ByVal cepId As Integer)

        strInstrucao = "DELETE FROM Cep WHERE CepId = @CepId"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@CepId", cepId)

    End Sub

    Public Function BuscarCep() As DataTable

        Dim dt As New DataTable
        Dim ds As New DataSet()
        strInstrucao = "SELECT CepId, Logradouro, Complemento, Bairro, Localidade, Estado, Unidade, Ibge, Gia FROM Cep"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao

        objConexao.Open()
        Dim da As New SqlDataAdapter(objCommand)
        da.Fill(ds)
        dt = ds.Tables(0)

        objConexao.Close()
        Return dt

    End Function

End Class
