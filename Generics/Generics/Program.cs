using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Gerenciador de Alunos
        var gerenciadorAlunos = new Gerenciador<Aluno>();

        Console.WriteLine("=== Cadastro de Alunos ===");
        Console.Write("Quantos alunos deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"\nAluno {i + 1}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nota final: ");
            double nota = double.Parse(Console.ReadLine());

            gerenciadorAlunos.Adicionar(new Aluno { Nome = nome, NotaFinal = nota });
        }

        var aprovados = gerenciadorAlunos.Filtrar(a => a.NotaFinal > 7);
        Console.WriteLine("\n=== Alunos aprovados (nota > 7) ===");
        foreach (var aluno in aprovados)
        {
            Console.WriteLine($"{aluno.Nome} - Nota: {aluno.NotaFinal}");
        }

        Console.WriteLine("\n=== Cadastro de Produtos ===");
        var gerenciadorProdutos = new Gerenciador<Produto>();

        Console.Write("Quantos produtos deseja cadastrar? ");
        int qtdProdutos = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtdProdutos; i++)
        {
            Console.WriteLine($"\nProduto {i + 1}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            gerenciadorProdutos.Adicionar(new Produto { Nome = nome, Preco = preco });
        }

        var caros = gerenciadorProdutos.Filtrar(p => p.Preco > 100);
        Console.WriteLine("\n=== Produtos com preço acima de 100 ===");
        foreach (var produto in caros)
        {
            Console.WriteLine($"{produto.Nome} - Preço: {produto.Preco}");
        }
    }
}