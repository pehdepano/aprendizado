using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class PessoaJuridica : Cliente
    {
        public PessoaJuridica(string codigo, string nome) : base(codigo, nome)
        {

        }

        public override decimal DescontarTaxa(decimal valor)
        {
            return valor - 2;
        }
    }
}