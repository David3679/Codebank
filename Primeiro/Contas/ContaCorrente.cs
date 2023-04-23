using Codebank;
using Codebank.Contas;
using Codebank.Funcionarios;
using Codebank.SistemaInterno;

//FUNCIONARIOS
#region
Diretores augusto = new Diretores("3232323-X5");
augusto.Nome = "Augusto Furtado";

Designers paulo = new Designers("2323232-X");
paulo.Nome = "Paulo Gigante";

Auxiliares matheus = new Auxiliares("23213123-G");
matheus.Nome = "Matheus Corsi";

GerenciadoresDeContas nicolas = new GerenciadoresDeContas("213421321-D");
nicolas.Nome = "Nicolas Viana";
#endregion

//CLIENTES
#region
ContaCorrente conta = new ContaCorrente(134,"1202-X");
conta.Titular = new Clientes();
conta.nome = "David Fernandes";
conta.cpf = "213213213-D";
conta.SetSaldo(900);


ContaCorrente conta1 = new ContaCorrente(230,"2340-T");
conta1.Titular = new Clientes();
conta1.nome = "Maria da Silva";
conta1.cpf = "213254676-T";
conta1.SetSaldo(800);


ContaCorrente conta2 = new ContaCorrente(312,"2034-G");
conta2.Titular = new Clientes();
conta2.nome = "Maria da Silva";
conta2.cpf = "2137546234-0";
conta2.SetSaldo(500);


ContaCorrente conta3 = new ContaCorrente(126, "1664-D");
conta3.Titular = new Clientes();
conta3.nome = "David";
conta3.cpf = "1413535653-03";
conta3.SetSaldo(700);
#endregion

//GERENCIADOR DE BONIFICAÇÂO
#region
CalcularBonificacao();
void CalcularBonificacao() { 
GerenciamentoDeBonificacao gerenciador = new GerenciamentoDeBonificacao();

    Diretores augusto = new Diretores("3232323-X5");
    augusto.Nome = "Augusto Furtado";

    Designers paulo = new Designers("2323232-X");
    paulo.Nome = "Paulo Gigante";

    Auxiliares matheus = new Auxiliares("23213123-G");
    matheus.Nome = "Matheus Corsi";

    GerenciadoresDeContas nicolas = new GerenciadoresDeContas("213421321-D");
    nicolas.Nome = "Nicolas Viana";


    gerenciador.Registar(augusto);
    gerenciador.Registar(paulo);
    gerenciador.Registar(matheus);
    gerenciador.Registar(nicolas);

    Console.WriteLine("Total de bonificacoes:"+gerenciador.TotalDeBonificacao);
}
#endregion

//LOGIN
#region
UsarSistema();
void UsarSistema()
{

    SistemaInterno sistema = new SistemaInterno();

    Diretores augusto = new Diretores("3232323-X5");
    augusto.Nome = "Augusto Furtado";
    augusto.Login = "augusto@gmail.com";
    augusto.Senha = "213";

    GerenciadoresDeContas nicolas = new GerenciadoresDeContas("213421321-D");
    nicolas.Nome = "Nicolas Viana";
    nicolas.Login = "nicolas@gmail.com";
    nicolas.Senha = "145";

    sistema.Logar(augusto, "213", "augusto@gmail.com");
    sistema.Logar(nicolas,"nicolas@gmail.com", "145");
}
#endregion