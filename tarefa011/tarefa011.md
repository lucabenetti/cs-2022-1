# Tarefa 011 - Padrões de Codificação (Leiaute e estilo), Reflexão e Programação defensiva - 08/07/2022

### Definição:
- Padrões de Codificação:
No desenvolvimento de software, se faz necessários estabelecer padrões na codificação, para que o código possa ser compreensível e entendimento de maneira rápida pelos vários integrantes de uma equipe, ou quem vier a futuramente realizar manutenção. Isto permite maior manutenção futura e entendimento.

Os padrões de codificação abrangem padrão de nomenclatura, organização de arquivos, organização de camadas, padrões de comentários, convenções de formatação, espaços em branco, indentação.
Convenção de nomes de classes, nomes de métodos, noems de interfaces, nomes de variáveis, nomes de constantes.

- Reflexão: é uma possibilidade nas linguagens de programação que permitem inspencionar/acessar valores de propriedades do próprio código em tempo de execução.

- Programação defensiva: A programação defensiva engloba um conjunto de práticas para que os casos em que entradas e dados não estejam na maneira esperada (nulos, não existam, estejam mal formatados) possam ser tratados e impedir a violação da integridade do sistema.

### Descrição de onde, quando, porque utilizá-los:
- Padrões de Codificação (Leiaute e estilo): A padronização do código facilita os processos de desenvolvimento, manutenção, análise e entedimento do código. Dessa forma há o acréscimo da produtividade da equipe de desenvolvimento.
- Reflexão: realizar ações que não sejam possíveis apenas com programação respeitando as regras de POO por exemplo, ou quando seja necessário alterar o funcionamento de um método, ou mesmo invocá-lo em tempo de execução, obtenção de todos modelos em tempo de execução, entre outras opções em que seja necessário realizar alguma ação que seja feita necessitando de obter como o programa está em execução. Criar instâncias e invocar métodos de forma dinâmica, obter informações de tipos.
- Programação defensiva: em qualquer sistema que tenha entrada de alguma forma, para a validação que as entradas estão de forma correta e em caso de não estar dentro do esperado, haver uma ação corretiva definida.

### Exemplos
- Padrões de codificação: definir o uso de camelCase em todo o projeto, definir que as interfaces sempre se iniciem com I.
- Reflexão: durante testes unitários, um método privado, por definição de POO, não poderia ser acessado/testado, entreganto, com o uso de reflexão, é possível alterar para aquela execução e caso específico a visibilidade do método.
- Programação defensiva: validação nos inputs/requests de usuários.