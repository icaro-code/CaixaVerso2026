

using ContaBancaria;

class Program
{
    static void Main()
    {
        var banco = new BancoService();

        var conta1 = new ContaCorrente(1001, "Alice", 500);
        var conta2 = new ContaPoupanca(2001, "Bruno", 1000);

        banco.AdicionarConta(conta1);
        banco.AdicionarConta(conta2);

        conta1.Depositar(200);
        conta1.Sacar(100);

        conta2.Depositar(300);
        conta2.RenderJuros(0.05m);

        conta1.ExibirExtrato();
        Console.WriteLine();
        conta2.ExibirExtrato();
    }
}

