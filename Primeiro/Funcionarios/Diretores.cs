using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Codebank.Funcionarios;
using Codebank.SistemaInterno;

namespace Codebank.Funcionarios
{
    public class Diretores : FuncionariosAutenticavel, IAutenticavel
    {
        public override double GetBonificacao()
        {
            return this.Salario;
        }

        public Diretores(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Diretor criado");
        }

        public override double GetPremioSeme()
        {
            return this.Salario *= 1.50;
        }
    }
}
