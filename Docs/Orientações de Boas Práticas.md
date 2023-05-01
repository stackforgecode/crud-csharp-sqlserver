## Princípios SOLID

### SRP - Princípio da Responsabilidade Única

Cada classe deve ter uma única responsabilidade. No projeto, isso pode ser alcançado garantindo que cada classe seja responsável por uma única tarefa, como a criação, leitura, atualização ou exclusão de registros no banco de dados.

### OCP - Princípio Aberto/Fechado

As classes devem estar abertas para extensão, mas fechadas para modificação. No projeto, isso pode ser alcançado através da utilização de interfaces para definir as operações de banco de dados e permitir a extensão do código sem a necessidade de modificar a implementação original.

### LSP - Princípio da Substituição de Liskov

As subclasses devem ser substituíveis por suas superclasses sem afetar o comportamento do programa. No projeto, isso pode ser alcançado garantindo que cada classe que implementa uma interface de banco de dados siga a mesma estrutura e comportamento esperado pela interface.

### ISP - Princípio da Segregação de Interfaces

As interfaces devem ser segregadas para que os clientes não precisem depender de funcionalidades que não usam. No projeto, isso pode ser alcançado criando interfaces específicas para cada operação de banco de dados, como criar, ler, atualizar e excluir registros.

### DIP - Princípio da Inversão de Dependência

Os módulos de alto nível não devem depender dos módulos de baixo nível, mas ambos devem depender de abstrações. No projeto, isso pode ser alcançado através da utilização de injeção de dependência para fornecer as dependências necessárias para cada classe. Isso permite que as classes sejam testadas independentemente e facilita a manutenção do código.

## Boas práticas adicionais

- Utilize nomes claros e descritivos para classes, métodos e variáveis.
- Adote um padrão consistente de codificação.
- Mantenha o código limpo e organizado.
- Faça uso de comentários para explicar o propósito do código e sua funcionalidade.
