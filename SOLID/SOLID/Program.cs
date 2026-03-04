using SOLID;

namespace SOLID
{
    class Program
    {
        static void Main()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.AdicionarProduto("Notebook", 3500m, 1);
            carrinho.AdicionarProduto("Mouse", 150m, 2);

            var pagamento = new Pagamento();
            pagamento.Processar(TipoPagamento.Credito, carrinho.ValorTotal);

            var comprovante = new Comprovante();
            comprovante.Imprimir(carrinho.ValorTotal);
        }
    }
}
