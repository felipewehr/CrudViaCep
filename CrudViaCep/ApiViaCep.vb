Imports System.Xml

Public Class ApiViaCep

    Public Function GetViaCep(ByVal iCEP As String, ByVal opcao As Integer) As String

        Dim RetornoXML As String = Nothing
        Dim request As System.Net.HttpWebRequest = CType(Net.WebRequest.Create("https://viacep.com.br/ws/" & iCEP & "/xml/"), Net.HttpWebRequest)
        Dim response As System.Net.HttpWebResponse
        Try
            response = CType(request.GetResponse(), Net.HttpWebResponse)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Function
        End Try
        If response.StatusCode = System.Net.HttpStatusCode.OK Then
            Dim stream As System.IO.Stream = response.GetResponseStream()
            Dim reader As New System.IO.StreamReader(stream)
            Dim contents As String = reader.ReadToEnd()
            If contents.Contains("(400)") Or contents.Contains("<erro>") Then
                MsgBox("Não foi possivel localizar o CEP")
                Exit Function
            End If
            Dim document As New System.Xml.XmlDocument()
            document.LoadXml(contents)
            Dim xnList As XmlNodeList = document.GetElementsByTagName("xmlCep")
            For Each xn As XmlNode In xnList
                Select Case opcao
                    Case 0
                        RetornoXML = xn("cep").InnerText
                    Case 1
                        RetornoXML = xn("logradouro").InnerText
                    Case 2
                        RetornoXML = xn("bairro").InnerText
                    Case 3
                        RetornoXML = xn("localidade").InnerText
                    Case 4
                        RetornoXML = xn("uf").InnerText
                    Case 5
                        RetornoXML = xn("complemento").InnerText
                    Case 6
                        RetornoXML = xn("ibge").InnerText
                End Select
            Next
        End If
        Return RetornoXML

    End Function

End Class
