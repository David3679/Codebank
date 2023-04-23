using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebank.Funcionarios
{
    public class Auxiliares : Funcionarios
    {
        public Auxiliares(string cpf):base(cpf,2000)
        {          
        }

        public override double GetBonificacao()
        {
            return this.Salario *= 0.2;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

        public override double GetPremioSeme()
        {
            return this.Salario *= 1.30;
        }
    }
}
