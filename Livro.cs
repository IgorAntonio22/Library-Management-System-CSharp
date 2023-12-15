using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C__Infnet
{
    internal class Livro : ItemBiblioteca, Emprestavel
    {
        private int prazoDeDevolucaoDias;
        public Livro(string titulo, string autor, int anoDePublicacao, Biblioteca biblioteca, int prazoDeDevolucaoDias) : base(titulo, autor, anoDePublicacao, biblioteca)
        {
            this.prazoDeDevolucaoDias = prazoDeDevolucaoDias;
        }

        //Exibe as informações do livro
        public override void exibirInformacoes()
        {
            Console.WriteLine($"Livro: {Titulo} - Autor: {Autor} - Ano de Publicação: {AnoDePublicacao} - Prazo de devolução máximo - {prazoDeDevolucaoDias} dias");
        }

        //Realiza a devolução do livro
        public override void devolver()
        {
            Console.WriteLine($"Livro '{Titulo}' devolvido à biblioteca '{Biblioteca.Nome}'.");
            Biblioteca.adicionarItem(this);
            Biblioteca.removerLivroOuRevistaEmprestado(this);
        }

        //Realiza o empréstimo do livro
        public override void emprestar()
        {
            Console.WriteLine($"Livro '{Titulo}' emprestado da biblioteca '{Biblioteca.Nome}'.");
            Biblioteca.adicionarLivroOuRevistaEmprestado(this);
            Biblioteca.removerItem(Titulo);
           
        }

        //Não houve necessidade de implementar pois o método exibirItens() da classe Biblioteca já realiza essa função.
        public void verificarDisponibilidade()
        {

        }
        
        //Adiciona o prazo de devolução informado no objeto com o dia e hora atual. 
        public override DateTime obterPrazoDeDevolucao()
        {
            return DateTime.Now.AddDays(prazoDeDevolucaoDias);
        }
    }
}
