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

            // 2 notas fiscais
            service.CadastrarNotaFiscal(new NotaFiscal { Numero = 1, Cliente = "Cliente A", ValorTotal = 319.70m });
            service.CadastrarNotaFiscal(new NotaFiscal { Numero = 2, Cliente = "Cliente B", ValorTotal = 500m });

            // Listar
            Console.WriteLine("\n--- Produtos ---");
            service.ListarProdutos();

            Console.WriteLine("\n--- Notas Fiscais ---");
            service.ListarNotas();
        }
    }

}