

using Repository;

public class Program
{
    public static void Main()
    {
        // 1. Criar Repository<Cliente>
        var repoClientes = new Repository<Cliente>();

        // 2. Adicionar 3 clientes
        repoClientes.Adicionar(new Cliente { Id = 1, Nome = "Alice" });
        repoClientes.Adicionar(new Cliente { Id = 2, Nome = "Bruno" });
        repoClientes.Adicionar(new Cliente { Id = 3, Nome = "Carla" });

        // 3. Buscar por Id
        var cliente = repoClientes.ObterPorId(2);
        Console.WriteLine($"Cliente encontrado: {cliente?.Nome}");

        // 4. Remover um cliente
        repoClientes.Remover(1);
        Console.WriteLine("Clientes restantes:");
        foreach (var c in repoClientes.ObterTodos())
        {
            Console.WriteLine($"{c.Id} - {c.Nome}");
        }
        // 5. Criar Repository<Pedido>
        var repoPedidos = new Repository<Pedido>();

        // 6. Repetir os testes
        repoPedidos.Adicionar(new Pedido { Id = 101, Descricao = "Pedido de livros" });
        repoPedidos.Adicionar(new Pedido { Id = 102, Descricao = "Pedido de notebook" });
        repoPedidos.Adicionar(new Pedido { Id = 103, Descricao = "Pedido de celular" });

        var pedido = repoPedidos.ObterPorId(102);
        Console.WriteLine($"Pedido encontrado: {pedido?.Descricao}");

        repoPedidos.Remover(101);
        Console.WriteLine("Pedidos restantes:");
        foreach (var p in repoPedidos.ObterTodos())
        {
            Console.WriteLine($"{p.Id} - {p.Descricao}");
        }
    }
}
