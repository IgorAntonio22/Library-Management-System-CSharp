using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C__Infnet
{
    internal class Biblioteca
    {
       
        private string nome;//Armazena o nome da biblioteca
        private List<ItemBiblioteca> itens; //Lista com todos os livros e revistas
        private List<ItemBiblioteca> livrosERevistasEmprestados; //Lista com todos os livros e revistas emprestados


        //Getters And Setters
        public List<ItemBiblioteca> obterLivrosERevistasEmprestados()
        {
            return livrosERevistasEmprestados;
        }
        public string Nome { get { return nome; } }
        public Biblioteca(string nome)
        {
            this.nome = nome;
            itens = new List<ItemBiblioteca>();
            livrosERevistasEmprestados = new List<ItemBiblioteca>();
        }

        //Adiciona um item a lista de todos os livros e revistas
        public void adicionarItem(ItemBiblioteca item)
        {
            itens.Add(item);
        }

        //Adiciona um item na lista de todos os livros e revistas através da digitação do título
        public void removerItem(string titulo)
        {
            ItemBiblioteca itemRemovido = itens.Find(indice => indice.Titulo == titulo);

            if (itemRemovido != null)
            {
                itens.Remove(itemRemovido);
                Console.WriteLine($"{itemRemovido.GetType().Name} '{itemRemovido.Titulo}' removido da biblioteca.");
            }
            else
            {
                Console.WriteLine($"Item '{titulo}' não encontrado na biblioteca.");
            }
        }

        //Adiciona um livro ou revista emprestado através do menu de empréstimo de livros 
        public void adicionarLivroOuRevistaEmprestado(ItemBiblioteca livro)
        {
            livrosERevistasEmprestados.Add(livro);
        }

        //Remove um livro ou revista emprestado através do menu de empréstimo de livros
        public void removerLivroOuRevistaEmprestado(ItemBiblioteca livro)
        {
            livrosERevistasEmprestados.Remove(livro);
        }

        //Encontra um ítem dentro da biblioteca através da digitação do título      
        public ItemBiblioteca encontrarItem(string titulo, Type tipo)
        {
            return itens.Find(item => item.Titulo == titulo && tipo.IsInstanceOfType(item));
        }

        //Encontra um ítem dentro dos livros ou revistas emprestados através da digitação do título   
        public ItemBiblioteca encontrarItemEmprestado(string titulo, Type tipo)
        {
            return livrosERevistasEmprestados.Find(item => item.Titulo == titulo && tipo.IsInstanceOfType(item));
        }

        //Exibe todos os livros e revistas da lista com todos os itens e livros disponíveis
        public void exibirItens()
        {
            Console.WriteLine($"Itens na biblioteca '{nome}':");
            foreach (ItemBiblioteca item in itens)
            {
                item.exibirInformacoes();
            }
        }

        //Exibe itens de um tipo expecífico (ou revista ou livro) com base no parâmetro passado
        public void exibirItens(Type tipo)
        {
            var itensFiltrados = itens.Where(item => tipo.IsInstanceOfType(item)).ToList();

            Console.WriteLine($"Itens do tipo {tipo.Name} na biblioteca '{nome}':");
            foreach (ItemBiblioteca item in itensFiltrados)
            {
                item.exibirInformacoes();
            }
        }

        //Exibe somente os livros que foram emprestados e não as revistas 
        public void exibirLivrosEmprestados()
        {
            var livrosEmprestados = livrosERevistasEmprestados
                .Where(item => item.GetType() == typeof(Livro))
                .ToList();

            Console.WriteLine($"Livros emprestados na biblioteca '{nome}':");
            foreach (ItemBiblioteca item in livrosEmprestados)
            {
                item.exibirInformacoes();
            }
        }

        //Exibe somente as revistas que foram emprestados e não os livros
        public void exibirRevistasEmprestadas()
        {
            var revistasEmprestadas = livrosERevistasEmprestados
                .Where(item => item.GetType() == typeof(Revista))
                .ToList();

            Console.WriteLine($"Revistas emprestadas na biblioteca '{nome}':");
            foreach (ItemBiblioteca item in revistasEmprestadas)
            {
                item.exibirInformacoes();
            }
        }

        
    }
}


