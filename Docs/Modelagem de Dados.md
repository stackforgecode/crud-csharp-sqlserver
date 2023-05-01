# 🗃️ PROPOSTA DE MODELAGEM DE DADOS 🛅

Para definir um modelo de dados para esse projeto, podemos seguir os seguintes passos:

1. Identificar as entidades envolvidas no projeto: com base na descrição do projeto, podemos identificar que a entidade principal é o objeto que será armazenado no banco de dados. Nesse caso, podemos definir a entidade como `Objeto`.

2. Identificar os atributos da entidade: para o `Objeto`, podemos identificar os seguintes atributos:

- `Id`: identificador único do objeto;
- `Nome`: nome do objeto;
- `Descricao`: descrição do objeto.

3. Definir o tipo de dados para cada atributo: para cada atributo, devemos definir qual o tipo de dado que será armazenado no banco de dados. Podemos definir os tipos de dados da seguinte forma:

- `Id`: int;
- `Nome`: varchar(50);
- `Descricao`: varchar(max).

4. Identificar as relações entre as entidades: nesse projeto, não existem outras entidades além do `Objeto`, portanto não é necessário definir relações entre elas.

5. Montar o diagrama de entidade e relacionamento (DER): com base nas informações coletadas nos passos anteriores, podemos montar o seguinte diagrama de entidade e relacionamento:

```
+-------+        +------------+
| Objeto|        | SQL Server |
+-------+        +------------+
| Id    |        |            |
| Nome  |        |            |
| Descricao |    |            |
+-------+        +------------+

+----------+ +------------------+
| Objeto | | SQL Server |
+----------+ +------------------+
| Id |1 * | Id |
| Nome |--------------| Nome varchar() |
| Descricao| | Descricao nvarchar() |
+----------+ +------------------+
```

6. Criar o script de criação da tabela no banco de dados: com base no DER e nos tipos de dados definidos, podemos criar o seguinte script de criação da tabela no SQL Server:

```sql
CREATE TABLE Objeto (
   Id INT IDENTITY(1,1) PRIMARY KEY,
   Nome VARCHAR(100) NOT NULL,
   Descricao NVARCHAR(300) NULL
);

```

7. Inserir dados de exemplo: podemos inserir dados de exemplo na tabela para verificar se a estrutura e o modelo de dados estão corretos. Para isso, podemos executar o seguinte script:

```sql
INSERT INTO Objeto (Nome, Descricao) VALUES
('Objeto 1', 'Descrição do objeto 1'),
('Objeto 2', 'Descrição do objeto 2'),
('Objeto 3', 'Descrição do objeto 3')
```
