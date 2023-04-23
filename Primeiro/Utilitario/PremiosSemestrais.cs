using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Codebank.Funcionarios;

namespace Codebank.Funcionarios
{
    public class PremiosSemestrais
    {
        public double PremioSemestral { get; set; }

        public void RegistroSeme(Funcionarios funcionarios) {

            this.PremioSemestral += funcionarios.GetPremioSeme();       
        }
    }
}
