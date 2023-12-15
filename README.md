# AT 5 - Sistema de Gerenciamento de Biblioteca

Crie uma **classe abstrata** chamada "ItemBiblioteca" que representará um item genérico de biblioteca. Essa classe deve conter os seguintes atributos: título, autor e ano de publicação. Além disso, ela deve ter os seguintes métodos abstratos: "emprestar()", "devolver()" e "exibirInformacoes()".

Crie **duas classes concretas** que herdem da classe abstrata "ItemBiblioteca": "Livro" e "Revista". Implemente os métodos abstratos de acordo com o comportamento esperado para cada item.

Crie **uma interface** chamada "Emprestavel" que contenha os seguintes métodos: "verificarDisponibilidade()" e "obterPrazoDeDevolucao()".

Faça com que as classes "Livro" e "Revista" implementem a interface "Emprestavel" e implemente os métodos de acordo com o comportamento esperado para cada item.

Crie uma classe chamada "Biblioteca" que será responsável por armazenar e gerenciar os itens da biblioteca. Essa classe deve possuir um array ou uma lista para armazenar os itens e os seguintes métodos: "adicionarItem(ItemBiblioteca item)", "removerItem(ItemBiblioteca item)", "exibirItens()" e "realizarEmprestimo(ItemBiblioteca item)".

Na classe principal do seu programa, crie alguns objetos do tipo "Livro" e "Revista", adicione-os à biblioteca, exiba a lista de itens e realize alguns empréstimos e devoluções para demonstrar o funcionamento do sistema.

Observações:
- Mantenha o código organizado e indentado.
- Utilize nomenclaturas de classes, métodos e instâncias conforme mostrado em aula.
- Utilize os conceitos de encapsulamento, herança, polimorfismo e abstração adequadamente.
- Você pode adicionar outros atributos e métodos às classes, caso julgue necessário.
- Para um melhor entendimento, comente o código explicando pontos importantes no desenvolvimento.

**OPCIONAL**
Caso deseje, faça o armazenamento desta lista em um arquivo. E ao abrir, informe um arquivo para buscar os dados já cadastrado (ou deixem fixo).
