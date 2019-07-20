Imports System.Data.SqlClient

Public Class ConexaoDB

    Public Const strConexao As String = "Data Source=;Initial Catalog=Cep;Integrated Security=True"
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

        strInstrucao = "UPDATE Cep SET Cep=@Cep, Logradouro=@Logradouro, Complemento=@Complemento, Bairro=@Bairro, Localidade=@Localidade, Estado=@Estado, Unidade=@Unidade, Ibge=@Ibge, Gia=@Gia WHERE CepId=@CepId"

    End Sub



End Class

Public Class Chep

    Dim Cep As String = String.Empty
    Dim Logradouro As String = String.Empty
    Dim Complemento As String = String.Empty
    Dim Bairro As String = String.Empty
    Dim Localidade As String = String.Empty
    Dim Uf As String = String.Empty
    Dim Unidade As String = String.Empty
    Dim Ibge As String = String.Empty
    Dim Gia As String = String.Empty

End Class
