using SOLID;

namespace SOLID
{
    class Program
    {
        static void Main()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.AdicionarProduto("Mouse", 79.90m, 2);
            carrinho.AdicionarProduto("Teclado", 159.90m, 1);

            // Total esperado: 319,70
            Console.WriteLine($"Total do carrinho: R$ {carrinho.ValorTotal:0.00}");

            // Executar com Pix
            IPagamento pagamento = new PagamentoPix(); // injeção manual
            pagamento.Pagar(carrinho.ValorTotal);

            var comprovante = new Comprovante();
            comprovante.Imprimir(carrinho.ValorTotal);
        }
    }
}
