using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebank.Funcionarios
{
    public class GerenciadoresDeContas : FuncionariosAutenticavel, IAutenticavel
    {

        public GerenciadoresDeContas(string cpf):base(cpf, 4000)
        {         
        }

        public override double GetBonificacao()
        {
            return this.Salario *= 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override double GetPremioSeme()
        {
            return this.Salario *= 1.10;
        }
    }
}
