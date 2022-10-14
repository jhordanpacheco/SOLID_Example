# SOLID


### Projeto extremamente básico, desenvolvido APENAS com o intuito de aplicar os 5 principais conceitos de SOLID.

  - [S]ingle Responsibility Principle (Princípio da Responsabilidade Única)
    - Uma classe deve ser responsável por fazer apenas um trabalho. Se a classe tem mais de uma responsabilidade, ela tende a ter um acoplamento. Uma mudança em uma responsabilidade resulta em modificação de outra responsabilidade.
    - Essa representação está sendo feita através da classe Produto.
    
    
  - [O]pen/Closed Principle (Princípio do Aberto/Fechado)
    - Consiste na reutilização. No exemplo do projeto o "AplicarDesconto” na classe de Produto, onde o método deve ser sobrescrito as classes filhas desse método, deixando a responsabilidade nas classes filhas (Fogao e Geladeira) e não na classe pai(Produto). 
  
  - [L]iskov Substitution Principle (Princípio da Substituição de Liskov)
    - Uma subclasse pode assumir sua superclasse sem erros. Se o código (superclasse) estiver verificando qual é o tipo da classe, está errado. No exemplo do projeto o "ObterCaracteristica", utilizado na superclasse (Produto) e subclasses (Fogao e Geladeira).
  
  - [I]nterface Segregation Principle (Princípio da Segregação de Interfaces)
    - Esse princípio nos avisa sobre o problema de utilizar interfaces muito grandes. No exemplo do projeto a interface IShape, que é utilizada pelas classes Triangule, Square, Rectangle e Circle, onde todas tem em comum o método Draw() porém cada uma da sua forma.
  
  - [D]ependency Inversion Principle (Princípio da Inversão de Dependência)
    - Esse princípio trata que nosso software é composto por componentes tanto em alto nível quanto em baixo nível. Quando isso ocorre temos que usar algum tipo de Injeção de Dependência para que possamos abstrair dos detalhes de implementação deste componentes, tirando o acoplamento e deixando nossas classes mais coesas.
    - Um exemplo clássico deste princípio é o padrão “Repository” aonde abstraímos dos detalhes de implementação do banco de dados ou um Storage qualquer.
    - No exemplo do projeto é a classe ProdutoRepository.
 
 ### 
