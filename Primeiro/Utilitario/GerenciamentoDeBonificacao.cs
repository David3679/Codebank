using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Codebank.Funcionarios
{
    public class GerenciamentoDeBonificacao
    {
        public double TotalDeBonificacao { get; set; }

        public void Registar(Funcionarios funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();

        }

        public double GetBonificacao()
        {
            return this.TotalDeBonificacao;
        }
    }
}
