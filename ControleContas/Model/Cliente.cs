using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Cliente
    {
/*      private string _nome;
        private string _cpf;
        private int _anoNasc;
*/
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public int AnoNascimento { get; private set; }  

    }
}
