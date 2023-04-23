using Codebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Codebank.Parceiros
{
    public class ParceirosComerciais : IAutenticavel
    {
        public string Senha { get ; set; }
        public string Login { get ; set; }

        public bool Autenticar(string senha, string login)
        {
            return this.Senha == senha;
        }
    }
}
