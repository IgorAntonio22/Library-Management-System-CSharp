namespace AT_C__Infnet
{
    internal class Program
    {

        //Menu de empréstimo de livros e revistas
        static void MenuEmprestimo(Biblioteca biblioteca)
        {
            int escolha;
            do
            {
                Console.WriteLine("\nMenu de Empréstimo:");
                Console.WriteLine("1 - Pegar livro emprestado");
                Console.WriteLine("2 - Pegar revista emprestada");
                Console.WriteLine("3 - Voltar ao Menu Principal");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            // Pegar livro emprestado
                            Console.WriteLine("\nLivros disponíveis:");
                            biblioteca.exibirItens(typeof(Livro));

                            Console.Write("Digite o título do livro que deseja pegar emprestado: ");
                            string tituloLivro = Console.ReadLine();

                            Livro livroEscolhido = (Livro)biblioteca.encontrarItem(tituloLivro, typeof(Livro));

                            if (livroEscolhido != null)
                            {
                                livroEscolhido.emprestar();
                                Console.WriteLine($"Livro '{livroEscolhido.Titulo}' foi emprestado com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine($"Livro '{tituloLivro}' não encontrado na biblioteca.");
                            }
                            break;

                        case 2:
                            // Pegar revista emprestada
                            Console.WriteLine("\nRevistas disponíveis:");
                            biblioteca.exibirItens(typeof(Revista));

                            Console.Write("Digite o título da revista que deseja pegar emprestada: ");
                            string tituloRevista = Console.ReadLine();

                            Revista revistaEscolhida = (Revista)biblioteca.encontrarItem(tituloRevista, typeof(Revista));

                            if (revistaEscolhida != null)
                            {
                                revistaEscolhida.emprestar();
                                Console.WriteLine($"Revista '{revistaEscolhida.Titulo}' foi emprestada com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine($"Revista '{tituloRevista}' não encontrada na biblioteca.");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Voltando ao Menu Principal.");
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }

            } while (escolha != 3);
        }

        //Menu de devolução de livros e revistas
        static void MenuDevolucao(Biblioteca biblioteca)
        {
            int escolha;
            do
            {
               
                Console.WriteLine("\nMenu de Devolução:");
                Console.WriteLine("1 - Devolver livro");
                Console.WriteLine("2 - Devolver revista");
                Console.WriteLine("3 - Voltar ao Menu Principal");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            // Devolver livro
                            Console.WriteLine("\nLivros emprestados:");
                            biblioteca.exibirLivrosEmprestados();

                            Console.Write("Digite o título do livro que deseja devolver: ");
                            string tituloLivro = Console.ReadLine();

                            Livro livroDevolvido = (Livro)biblioteca.encontrarItemEmprestado(tituloLivro, typeof(Livro));

                            if (livroDevolvido != null)
                            {
                                livroDevolvido.devolver();
                                Console.WriteLine($"Livro '{livroDevolvido.Titulo}' foi devolvido com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine($"Livro '{tituloLivro}' não encontrado na lista de livros emprestados.");
                            }
                            break;

                        case 2:
                            // Devolver revista
                            Console.WriteLine("\nRevistas emprestadas:");
                            biblioteca.exibirRevistasEmprestadas();

                            Console.Write("Digite o título da revista que deseja devolver: ");
                            string tituloRevista = Console.ReadLine();

                            Revista revistaEscolhida = (Revista)biblioteca.encontrarItemEmprestado(tituloRevista, typeof(Revista));

                            if (revistaEscolhida != null)
                            {
                                revistaEscolhida.devolver();
                                Console.WriteLine($"Revista '{revistaEscolhida.Titulo}' foi devolvida com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine($"Revista '{tituloRevista}' não encontrada na lista de revistas emprestadas.");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Voltando ao Menu Principal.");
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }

            } while (escolha != 3);
        }

        
        static void Main(string[] args)
        {

            // Pedindo ao usuário para digitar o nome da nova biblioteca
            Console.Write("Digite o nome da nova biblioteca: ");
            string nomeBiblioteca = Console.ReadLine();

            // Criando uma instância da Biblioteca
            Biblioteca biblioteca = new Biblioteca(nomeBiblioteca);

            // Criando 10 instâncias de Livro e 10 instâncias de Revista e adicionando à biblioteca
            Livro livro1 = new Livro("A Arte da Guerra", "Sun Tzu", 500, biblioteca, 14);
            Livro livro2 = new Livro("1984", "George Orwell", 1949, biblioteca, 21);
            Livro livro3 = new Livro("Cem Anos de Solidão", "Gabriel García Márquez", 1967, biblioteca, 14);
            Livro livro4 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, biblioteca, 30);
            Livro livro5 = new Livro("Dom Quixote", "Miguel de Cervantes", 1605, biblioteca, 14);
            Livro livro6 = new Livro("Crime e Castigo", "Fiódor Dostoiévski", 1866, biblioteca, 21);
            Livro livro7 = new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 1943, biblioteca, 7);
            Livro livro8 = new Livro("A Revolução dos Bichos", "George Orwell", 1945, biblioteca, 14);
            Livro livro9 = new Livro("Orgulho e Preconceito", "Jane Austen", 1813, biblioteca, 14);
            Livro livro10 = new Livro("A Cabana", "William P. Young", 2007, biblioteca, 14);

            Revista revista1 = new Revista("National Geographic", "Editora Abril", 1888, biblioteca, 7);
            Revista revista2 = new Revista("Veja", "Editora Abril", 1968, biblioteca, 7);
            Revista revista3 = new Revista("Time", "Time Inc.", 1923, biblioteca, 7);
            Revista revista4 = new Revista("Scientific American", "Springer Nature", 1845, biblioteca, 7);
            Revista revista5 = new Revista("The New Yorker", "Condé Nast", 1925, biblioteca, 7);
            Revista revista6 = new Revista("Forbes", "Integrated Whale Media", 1917, biblioteca, 7);
            Revista revista7 = new Revista("Wired", "Condé Nast", 1993, biblioteca, 7);
            Revista revista8 = new Revista("Rolling Stone", "Wenner Media", 1967, biblioteca, 7);
            Revista revista9 = new Revista("Harvard Business Review", "Harvard University", 1922, biblioteca, 7);
            Revista revista10 = new Revista("Nature", "Springer Nature", 1869, biblioteca, 7);

            // Adicionando itens à biblioteca
            biblioteca.adicionarItem(livro1);
            biblioteca.adicionarItem(livro2);
            biblioteca.adicionarItem(livro3);
            biblioteca.adicionarItem(livro4);
            biblioteca.adicionarItem(livro5);
            biblioteca.adicionarItem(livro6);
            biblioteca.adicionarItem(livro7);
            biblioteca.adicionarItem(livro8);
            biblioteca.adicionarItem(livro9);
            biblioteca.adicionarItem(livro10);

            biblioteca.adicionarItem(revista1);
            biblioteca.adicionarItem(revista2);
            biblioteca.adicionarItem(revista3);
            biblioteca.adicionarItem(revista4);
            biblioteca.adicionarItem(revista5);
            biblioteca.adicionarItem(revista6);
            biblioteca.adicionarItem(revista7);
            biblioteca.adicionarItem(revista8);
            biblioteca.adicionarItem(revista9);
            biblioteca.adicionarItem(revista10);


            // Menu principal
            int escolha;
            do
            {
              
                Console.WriteLine("\nMenu Principal:");
                Console.WriteLine("1 - Menu de Empréstimo");
                Console.WriteLine("2 - Menu de Devolução");
                Console.WriteLine("3 - Verificar Disponibilidade de Livros e Revistas");
                Console.WriteLine("4 - Obter Prazo de Devolução");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            // Menu de Empréstimo
                            MenuEmprestimo(biblioteca);
                            break;

                        case 2:
                            // Menu de Devolução
                            MenuDevolucao(biblioteca);
                            break;

                        case 3:
                            biblioteca.exibirItens();
                            break;

                        case 4:

                            // Obtendo a lista de livros e revistas emprestadas
                            List<ItemBiblioteca> livrosERevistasEmprestadas = biblioteca.obterLivrosERevistasEmprestados();

                            // Iterando sobre os itens emprestados
                            foreach (ItemBiblioteca item in livrosERevistasEmprestadas)
                            {
                                // Verificar se o item é do tipo Livro
                                if (item is Livro livro)
                                {
                                    // Chama obterPrazoDeDevolucao para cada livro
                                    DateTime prazoDevolucao = livro.obterPrazoDeDevolucao();
                                    Console.WriteLine($"Livro '{livro.Titulo}' - Prazo de devolução: {prazoDevolucao}");
                                }
                                // Verificar se o item é do tipo Revista
                                else if (item is Revista revista)
                                {
                                    // Chama obterPrazoDeDevolucao para cada revista
                                    DateTime prazoDevolucao = revista.obterPrazoDeDevolucao();
                                    Console.WriteLine($"Revista '{revista.Titulo}' - Prazo de devolução: {prazoDevolucao}");
                                }
                            }
                            break;
                        case 5:

                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }

            } while (escolha != 5);
        }   
     }
 }
 
