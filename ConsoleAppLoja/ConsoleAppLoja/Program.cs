using ConsoleAppLoja;
using System;

public class Program
{
    public static void Main()
    {
        // Produtos disponíveis
        var p1 = new Produto(1, "Teclado", 120.00m);
        var p2 = new Produto(2, "Mouse", 80.00m);
        var p3 = new Produto(3, "Monitor", 950.00m);

        Console.WriteLine("=== Bem-vindo à Loja ===");
        Console.WriteLine("Produtos disponíveis:");
        Console.WriteLine($"1 - {p1.Nome} (R$ {p1.Preco})");
        Console.WriteLine($"2 - {p2.Nome} (R$ {p2.Preco})");
        Console.WriteLine($"3 - {p3.Nome} (R$ {p3.Preco})");
        Console.WriteLine("Digite 0 para finalizar a escolha.");

        var carrinho = new Carrinho();

        while (true)
        {
            Console.Write("Digite o número do produto desejado (ou 0 para terminar): ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 0)
                break;

            Produto produtoEscolhido = escolha switch
            {
                1 => p1,
                2 => p2,
                3 => p3,
                _ => null
            };

            if (produtoEscolhido == null)
            {
                Console.WriteLine("Produto inválido!");
                continue;
            }

            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            carrinho.Adicionar(produtoEscolhido, quantidade);
            Console.WriteLine($"{quantidade}x {produtoEscolhido.Nome} adicionados ao carrinho!");
        }

        // Mostrar resumo do carrinho
        Console.WriteLine("\n=== Resumo do Carrinho ===");
        carrinho.ExibirResumo();

        // Solicitar endereço de entrega
        Console.Write("\nDigite o endereço de entrega: ");
        string endereco = Console.ReadLine();

        // Escolher tipo de entrega
        Console.WriteLine("Escolha o tipo de entrega:");
        Console.WriteLine("1 - Normal");
        Console.WriteLine("2 - Expressa");
        int tipoEntrega = int.Parse(Console.ReadLine());

        EntregaBase entrega = tipoEntrega == 2
            ? new EntregaExpressa(endereco)
            : new EntregaNormal(endereco);

        // Cupom opcional
        var cupom = new Cupom("PROMO10", 0.10m);

        // Finalizar checkout
        var checkout = new Checkout(carrinho, entrega, cupom);
        checkout.Finalizar();
    }
}