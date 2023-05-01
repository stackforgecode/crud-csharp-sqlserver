## Dependências e Versionamento

### Dependências

- SKD .NET 6 (LTS)
- Pacotes Nuget:
  - Microsoft.Extensions.DependencyInjection
  - Microsoft.Extensions.Logging
  - Microsoft.Extensions.Logging.Console
  - Microsoft.Data.SqlClient
  - Dapper
- Azure Data Studio
- SQL Server

### Versionamento

- O versionamento do código será gerenciado através do Git.
- O fluxo de trabalho seguirá o modelo GitFlow.
- A versão atual da aplicação é a 1.0.0 e está disponível no branch master.
- Para cada nova feature ou correção de bug, um novo branch será criado a partir do branch develop.
- Quando uma feature ou correção estiver concluída, será criado um pull request para o branch develop e a alteração será revisada por um ou mais desenvolvedores antes de ser mergeada.
- As versões serão marcadas com tags no formato MAJOR.MINOR.PATCH, seguindo as diretrizes do SemVer (Semantic Versioning).
- As alterações de versão serão registradas em um arquivo CHANGELOG.md.
