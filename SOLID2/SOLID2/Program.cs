namespace SOLID2
{
    class Program
    {
        static void Main()
        {
            var repoProduto = new ProdutoRepositorioComValidacao();
            var repoNotaFiscal = new NotaFiscalRepositorioEmMemoria();
            var logger = new ConsoleLogger();
            var validadorProduto = new ValidadorProduto();

            var service = new CadastroService(
                repoProduto, repoProduto,
                repoNotaFiscal, repoNotaFiscal,
                logger, validadorProduto);

            // 2 produtos válidos
            service.CadastrarProduto(new Produto { Id = Guid.NewGuid(), Descricao = "Mouse", ValorUnitario = 79.90m });
            service.CadastrarProduto(new Produto { Id = Guid.NewGuid(), Descricao = "Teclado", ValorUnitario = 159.90m });

            // 1 produto inválido
            service.CadastrarProduto(new Produto { Id = Guid.NewGuid(), Descricao = "", ValorUnitario = 100m });

            // Perguntar nomes dos clientes
            Console.Write("Informe o nome do cliente da Nota Fiscal 1: ");
            string cliente1 = Console.ReadLine();

            Console.Write("Informe o nome do cliente da Nota Fiscal 2: ");
            string cliente2 = Console.ReadLine();

            // 2 notas fiscais com nomes informados pelo usuário
            service.CadastrarNotaFiscal(new NotaFiscal { Numero = 1, Cliente = cliente1, ValorTotal = 319.70m });
            service.CadastrarNotaFiscal(new NotaFiscal { Numero = 2, Cliente = cliente2, ValorTotal = 500m });

            // Listar
            Console.WriteLine("\n--- Produtos ---");
            service.ListarProdutos();

            Console.WriteLine("\n--- Notas Fiscais ---");
            service.ListarNotas();
        }
    }
}