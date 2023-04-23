using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Codebank.Funcionarios;

namespace Codebank.Contas
{
    public class ContaCorrente : Clientes
    {
        private int numero_agencia;
       
        public int Numero_agencia
        {
            get { return numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    numero_agencia = value;
                }
            } 
        }

        public string Conta { get; set; }

        private double saldo;

        public Clientes Titular { get; set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor < saldo)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                saldo = valor;
            }

        }

        public double GetSaldo()
        {
            return saldo;
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            Numero_agencia = numero_agencia;
            Conta = numero_conta;
        }
    }
}