using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entidade Produto: representa um item vendável com regras de negócio básicas


namespace ProjetoPedidos.Domain.Entities
{
    public class Produto    // Declaração de uma classe chamada Produto

    {
        public int Id { get; }  // Propriedade somente leitura chamada Id, do tipo inteiro

        public string Nome { get; }
        public decimal Preco { get; }

        public Produto(int id, string nome, decimal preco)  // Construtor da classe Produto que inicializa Id, Nome e Preço

        {
            if (string.IsNullOrWhiteSpace(nome))    // Verifica se a variável nome está vazia ou só com espaços
                throw new ArgumentException("Nome obrigatório");
            if (preco <= 0)
                throw new ArgumentException("Preço deve ser > 0");

            Id = id;
            Nome = nome;
            Preco = preco;
        }
    }
}
