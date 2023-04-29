# 📋 Projeto CRUD Singleton com C# e SQL Server

Este projeto tem como objetivo demonstrar a implementação do padrão Singleton em um aplicativo de console C# com acesso ao banco de dados SQL Server. A aplicação realiza operações CRUD (Create, Read, Update e Delete) com o banco de dados.

## 🚀 Instruções para baixar e rodar o projeto

1. Clone este repositório em sua máquina local utilizando o seguinte comando:

```bash
git clone https://github.com/stackforgecode/crud-csharp-sqlserver.git

// navega até o diretório crud-csharp-sqlserver/

cd crud-csharp-sqlserver/

// Verifique se o dotnet-cli está instalado corretamente:
dotnet --version
```

2. Abra o projeto no Visual Studio ou Visual Studio Code.

3. Crie uma aplicação de console usando a CLI do dotnet:

```bash
dotnet new console -n crud-csharp-sqlserver -f net6.0
```

3. Ainda utilizando a CLI, vamos adicionar:

```bash
dotnet new gitignore

dotnet new webconfig

dotnet add package System.Data.SqlClient

dotnet add package System.Configuration.ConfigurationManager

dotnet new xunit
```

4. Abra o arquivo `web.config` na pasta do projeto e verifique se a string de conexão está correta.

5. Execute o projeto e teste as operações CRUD.

## 🧰 Tecnologias utilizadas

- C#
- SQL Server
- Nuget
- xUnit

## 📝 Referências

- [Microsoft SQL Server](https://www.microsoft.com/pt-br/sql-server/)
- [Como utilizar a classe SqlCommand](https://learn.microsoft.com/pt-br/dotnet/framework/data/adonet/sql/linq/how-to-directly-execute-sql-commands)
- [Modelando uma consultado com a classe SqlCommand](https://learn.microsoft.com/pt-br/dotnet/framework/data/adonet/sql/linq/walkthrough-simple-object-model-and-query-csharp)
- [Método ExecuteCommand](https://learn.microsoft.com/pt-br/dotnet/framework/data/adonet/sql/linq/how-to-directly-execute-sql-commands)
- [Microsoft.Data.SqlClient](https://www.nuget.org/packages/Microsoft.Data.SqlClient/)
- [Singleton Design Pattern in C#](https://www.c-sharpcorner.com/article/singleton-design-pattern-in-c-sharp/)
- [xunit](https://xunit.net/)
