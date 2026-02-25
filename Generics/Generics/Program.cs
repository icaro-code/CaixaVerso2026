class Program
{
    static void Main(string[] args)
    {
        // Gerenciador de Alunos
        var gerenciadorAlunos = new Gerenciador<Aluno>();
        gerenciadorAlunos.Adicionar(new Aluno { Nome = "Ana", NotaFinal = 8.5 });
        gerenciadorAlunos.Adicionar(new Aluno { Nome = "Bruno", NotaFinal = 6.7 });
        gerenciadorAlunos.Adicionar(new Aluno { Nome = "Carla", NotaFinal = 9.0 });

        var aprovados = gerenciadorAlunos.Filtrar(a => a.NotaFinal > 7);
        Console.WriteLine("Alunos aprovados:");
        foreach (var aluno in aprovados)
        {
            Console.WriteLine($"{aluno.Nome} - Nota: {aluno.NotaFinal}");
        }

        Console.WriteLine();

        // Gerenciador de Produtos
        var gerenciadorProdutos = new Gerenciador<Produto>();
        gerenciadorProdutos.Adicionar(new Produto { Nome = "Notebook", Preco = 3500 });
        gerenciadorProdutos.Adicionar(new Produto { Nome = "Mouse", Preco = 80 });
        gerenciadorProdutos.Adicionar(new Produto { Nome = "Celular", Preco = 1200 });

        var caros = gerenciadorProdutos.Filtrar(p => p.Preco > 100);
        Console.WriteLine("Produtos com preço acima de 100:");
        foreach (var produto in caros)
        {
            Console.WriteLine($"{produto.Nome} - Preço: {produto.Preco}");
        }
    }
}
