﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebank.Funcionarios
{
    public abstract class FuncionariosAutenticavel : Funcionarios, IAutenticavel
    {
        public FuncionariosAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }
        public string Login { get ; set ; }

        public bool Autenticar(string senha, string login)
        {
            return this.Senha == senha;
        }
    }
}
