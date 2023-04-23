using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebank.Funcionarios
{
    public abstract class Funcionarios
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        public int tipo;

        public abstract double GetBonificacao();
    
        public abstract double GetPremioSeme(); 

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public Funcionarios(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;

            TotalDeFuncionarios++;

            Console.WriteLine("Funcionário criado");
        }
    }
}

