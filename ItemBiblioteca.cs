using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C__Infnet
{
    internal abstract class ItemBiblioteca
    {

        //Variáveis de instância
        private string titulo;
        private string autor;
        private int anoDePublicacao;
        private Biblioteca biblioteca;

        //Método que será sobrescrito pelas classes filhas
        public virtual DateTime obterPrazoDeDevolucao()
        {
            return DateTime.Now;
        }


        //Getters And Setters
        protected Biblioteca Biblioteca { get { return biblioteca; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Autor { get {  return autor; } set {  autor = value; } }
        
        public int AnoDePublicacao { get {  return anoDePublicacao; } set {  anoDePublicacao = value; } }

        //Passa através do seu construtor todas as informações dos livros e revistas e um objeto do tipo Biblioteca para manipulação em outras classes
        public ItemBiblioteca(string titulo, string autor, int anoDePublicacao, Biblioteca biblioteca)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoDePublicacao = anoDePublicacao;
            this.biblioteca = biblioteca;
        }

        //Métodos abstratos que devem ser implementados pelas classes filhas obrigatóriamente
        public abstract void emprestar();
        public abstract void devolver();

        public abstract void exibirInformacoes();

    }
}
