using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class PessoaFisica : Cliente
    {
        public PessoaFisica(string codigo, string nome) : base(codigo, nome)
        {

        }

        public override decimal DescontarTaxa(decimal valor)
        {
            return valor - 1;
        }
    }
}