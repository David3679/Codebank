using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebank.Funcionarios
{
    public class Designers : Funcionarios
    {
        public Designers(string cpf):base(cpf, 3000)
        {   
        }

        public override double GetBonificacao()
        {
            return this.Salario *= 0.17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

        public override double GetPremioSeme()
        {
            return this.Salario *= 1.20;
        }
    }
}
