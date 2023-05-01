# 📋 PROJETO `CRUD Singleton` COM `C#` E `SQL Server`

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

## 🧰 TECNOLOGIAS UTILIZADAS

### ⚙️ Ferramentas e Recursos

- Editor de Código so seu crivo
  - Visual Studio Code (minha escolha para o projeto)
- Ferramenta gráfica para gerenciamento de Banco de Dados
  - Azure Data Studio (minha escolha para o projeto)
- SGBD - Sistema Gerenciador de Banco de Dados:
  - SQL Server - https://www.microsoft.com/pt-br/sql-server/sql-server-downloads
- Gerenciador de Pacotes:

  - Nuget
    • https://www.nuget.org/
  - Github .NET
    • https://github.com/orgs/dotnet/packages

- SKD .NET 6 (LTS)
- C# - Linguagem de Programação
  - https://dotnet.microsoft.com/en-us/download
- Git (recomendo a última versão)
  - https://git-scm.com/
- Gitflow - Modelo de fluxo de trabalho para padronização de commits, ramificações, releases e tags:
  - https://www.atlassian.com/br/git/tutorials/comparing-workflows/gitflow-workflow

### 🗄 Opcionais:

- Docker

  - https://www.docker.com/products/docker-desktop/
  - https://rancherdesktop.io/

- Diagramação de Banco de Dados:

  - https://dbdiagram.io/home

- Conversores de códigos:

  - JSon para C#:
    - https://json2csharp.com/
  - JSON para SQL:

    - https://www.convertjson.com/json-to-sql.htm
    - https://sqlbook.io/json2sql

  - SQL Múltiplas sintaxes:
    - https://sqlines.com/online

<hr>

## 📝 REFERÊNCIAS

### 📰 Artigos on-line

- [Microsoft SQL Server](https://www.microsoft.com/pt-br/sql-server/)
- [Como utilizar a classe SqlCommand](https://learn.microsoft.com/pt-br/dotnet/framework/data/adonet/sql/linq/how-to-directly-execute-sql-commands)
- [Modelando uma consultado com a classe SqlCommand](https://learn.microsoft.com/pt-br/dotnet/framework/data/adonet/sql/linq/walkthrough-simple-object-model-and-query-csharp)
- [Método ExecuteCommand](https://learn.microsoft.com/pt-br/dotnet/framework/data/adonet/sql/linq/how-to-directly-execute-sql-commands)
- [Microsoft.Data.SqlClient](https://www.nuget.org/packages/Microsoft.Data.SqlClient/)
- [Singleton Design Pattern in C#](https://www.c-sharpcorner.com/article/singleton-design-pattern-in-c-sharp/)
- [xunit](https://xunit.net/)

## 📚 Livros

- VALENTE, Marco Tulio de Oliveira. Engenharia de software moderna: abordagens e metodologias para sistemas de software. São Paulo: Novatec Editora, 2015.

- TELES, Vinícius Manhães; SANTANA, Paulo Meirelles. Extreme Programming: aprenda como encantar seus usuários desenvolvendo software com agilidade e alta qualidade. Rio de Janeiro: Alta Books, 2017.

- VAZQUES, Carlos Eduardo; SIMÕES, Guilherme Siqueira. Engenharia de requisitos: software orientado ao negócio. São Paulo: Érica, 2016.

- GAMMA, Erich; HELM, Richard; JOHNSON, Ralph; VLISSIDES, John. Padrões de Projeto: soluções reutilizáveis de software orientado a objetos. Porto Alegre: Bookman, 2000.
