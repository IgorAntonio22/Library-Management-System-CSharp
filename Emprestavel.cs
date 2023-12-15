using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C__Infnet
{
    internal interface Emprestavel
    {
        //Faz um contrato de implementação dos métodos abaixo para as classes que implementarem essa Interface
        public abstract void verificarDisponibilidade();
        public abstract DateTime obterPrazoDeDevolucao();
    }
}
