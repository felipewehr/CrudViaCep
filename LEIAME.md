# **CrudViaCep**

### DESCRIÇÃO
- Sistema CRUD (Create, Restore, Update, Delete) integrado a API ViaCep, criado para fins de estudo.
- Permite a persistencia de dados de Endereço da API ViaCep

### CARACTERISTICAS
- Banco de Dados SQL Server
- Programação Orientada a Objetos
- Integração com API ViaCep
- Tratamento de erros
- Validação de inputs de formulario
- .NET Framework 4.6.1

---
# #1 - Estruturas do Banco de dados

### Observações
- Dump da base de dados junto ao arquivo
- Configuração de conexão em "ConexaoDB.vb"/"strConexao"

### SCRIPT SQL

		use CrudViaCep

		CREATE TABLE Cep
		(
		          CepId			INT IDENTITY(1,1) NOT NULL
		        , Cep			VARCHAR(8)        NOT NULL
		        , Logradouro    VARCHAR(50)           NULL
				, Complemento   VARCHAR(50)           NULL
		        , Bairro		VARCHAR(50)           NULL
		        , Localidade	VARCHAR(50)           NULL
		        , Estado		VARCHAR(5)            NULL
				, Unidade		VARCHAR(10)			  NULL
				, Ibge			VARCHAR(10)			  NULL
				, Gia			VARCHAR(10)			  NULL
		        , CONSTRAINT PK_CepId PRIMARY KEY (CepId)
		)

### BUGFIX
- System.Data.SqlClient.SqlException: 'Dados de cadeia ou binários seriam truncados.'
---
# #2 - Tela de Listagem

---
# #3 - Tela de Cadastro

### CEP
- **CEPs para teste**: 85900-220; 85901-245; 85902-410

---
# #4 - Consumo de API ViaCep

### BUGFIX
- API responde porem não retorna nenhum dado