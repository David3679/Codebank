using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codebank.Funcionarios;

namespace Codebank.Funcionarios
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }

        public string Login { get; set; }

        public abstract bool Autenticar(string senha, string login);
    }
}
