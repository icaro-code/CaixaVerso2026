

using ContaBancaria;

class Program
{
    static void Main()
    {
        // Criando as contas
        var contaCorrente = new ContaCorrente(1001, "Alice", 500);
        var contaPoupanca = new ContaPoupanca(2001, "Bruno", 1000);
        var contaJuridica = new ContaJuridica(3001, "Empresa XPTO", 5000, "12.345.678/0001-99");

        // Operações na Conta Corrente
        contaCorrente.Depositar(200);
        contaCorrente.Sacar(100);

        // Operações na Conta Poupança
        contaPoupanca.Depositar(300);
        contaPoupanca.RenderJuros(0.05m);

        // Operações na Conta Jurídica
        contaJuridica.Depositar(2000);
        contaJuridica.Sacar(1000);
        contaJuridica.SolicitarEmprestimo(10000);

        // Exibir extratos
        Console.WriteLine("=== Extratos ===\n");
        contaCorrente.ExibirExtrato();
        Console.WriteLine();
        contaPoupanca.ExibirExtrato();
        Console.WriteLine();
        contaJuridica.ExibirExtrato();
    }
}
