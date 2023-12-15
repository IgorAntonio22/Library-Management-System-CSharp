using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C__Infnet
{
    internal class Revista : ItemBiblioteca, Emprestavel
    {
        private string editora;
        private int prazoDeDevolucaoDias;

        public Revista(string titulo, string editora, int anoDePublicacao, Biblioteca biblioteca, int prazoDeDevolucaoDias) : base(titulo, null, anoDePublicacao, biblioteca)
        {
           this.editora = editora;
           this.prazoDeDevolucaoDias = prazoDeDevolucaoDias;
        }

        //Exibe as informações da revista
        public override void exibirInformacoes()
        {
            Console.WriteLine($"Revista: {Titulo} - Editora: {editora} - Ano de Publicação: {AnoDePublicacao}  Prazo de devolução máximo - {prazoDeDevolucaoDias} dias");
        }

        //Realiza a devolução da revista
        public override void devolver()
        {
            Console.WriteLine($"Revista '{Titulo}' devolvida à biblioteca '{Biblioteca.Nome}'.");
            Biblioteca.adicionarItem(this);
            Biblioteca.removerLivroOuRevistaEmprestado(this);
        }

        //Realiza o empréstimo da revista
        public override void emprestar()
        {
            Console.WriteLine($"Revista '{Titulo}' emprestada da biblioteca '{Biblioteca.Nome}'.");
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
