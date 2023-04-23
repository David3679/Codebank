using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebank
{
    public class Clientes
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string profissao { get; set; }
        public static int TotalDeContasCadastradas { get; private set; }

        public Clientes()
        {
            TotalDeContasCadastradas = TotalDeContasCadastradas + 1;
        }
    }
}
