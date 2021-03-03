
# CHAIN OF RESPONSABILITY
## Aplicando o Padrão Chain Responsability com C#, mostrando 3 cenários sem o padrão  e com o padrão aplicado.

- A intenção deste padrão é evitar o acoplamento do remetente de uma solicitação ao seu receptor, ao dar mais de um objeto a oportunidade de tratar essa solicitação.
- Encadear os objetos receptores, passando a solicitação ao longo da cadeia até que um objeto o trate.


## Estrutura

### Passo a passo

- A base mantém um ponteiro como "proximo"
- Cada classe precisa ser passado para outra classe, então a classe derivada "chama de volta" à classe padrão, delegando um novo ponteiro.
- O cliente (terceirizado ou não) cria e encadeia, a qual pode incluir uma ligação do último nó até o nó raiz;
- O cliente lança e deixa cada request com a raiz da cadeia;
- As delegações recursivas produzem um efeito de ilusão.

## Situação de uso

- Mais de um objeto pode tratar uma solitação e o objeto que o tratará não é conhecido a priori.
- O objeto que trata a solicitação deve ser escolhido automaticamente;
- Deve-se emitir uma soliticação para um dentre vários objetos, sem especificar explicitamente o receptor;
- O conjunto de objetos que pode tratar uma solicitação deveria ser especificado dinamicamente.

### Exemplo
  - Em um escritório, por exemplo, onde se tem 4 linhas telefônicas, a primeira linha é o primeiro objeto, a segunda linha é o segundo, e assim sucessivamente até a gravação automática que é o quinto objeto.
  - Se a primeira linha estiver disponivel ela irá tratar a ligação, se não ela passa a tarefa para o próximo objeto, que é a segunda linha. 
  - Se essa linha estiver ocupada ela passa a tarefa para a próxima e assim sucessivamente até que um objeto possa tratar a tarefa.
  - Nesse caso, se todas as linhas estiverem ocupadas o último objeto, que é a gravação automática, tratará da tarefa.
  
#### Veja os exemplos na implementação.

Fontes:
  - https://www.devmedia.com.br/design-patterns-entendendo-os-padroes-chain-of-responsibility-command-iterator-mediator-e-memento/29397
  - https://pt.wikipedia.org/wiki/Chain_of_Responsibility
