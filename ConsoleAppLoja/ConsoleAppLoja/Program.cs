using ConsoleAppLoja;

public class Program
{
    public static void Main()
    {
        var p1 = new Produto(1, "Teclado", 120.00m);
        var p2 = new Produto(2, "Mouse", 80.00m);
        var p3 = new Produto(3, "Monitor", 950.00m);

        var carrinho = new Carrinho();
        carrinho.Adicionar(p1);
        carrinho.Adicionar(p2, 2);
        carrinho.Adicionar(p1, 1);
        carrinho.Adicionar(p2, p3);

        carrinho.ExibirResumo();

        EntregaBase entregaNormal = new EntregaNormal("Av. Brasil, 1000 - Rio de Janeiro - RJ");
        var cupom = new Cupom("PROMO10", 0.10m);

        var checkout = new Checkout(carrinho, entregaNormal, cupom);
        checkout.Finalizar();

        Console.WriteLine();
        Console.WriteLine("=== Troca para entrega expressa ===");
        var checkout2 = new Checkout(carrinho, new EntregaExpressa("Av. Brasil, 1000 - Rio de Janeiro - RJ"));
        checkout2.Finalizar();
    }
}