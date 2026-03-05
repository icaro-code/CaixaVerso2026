using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedidos.Domain.Entities
{
    public class Produto
    {
        public int Id { get; }
        public string Nome { get; }
        public decimal Preco { get; }

        public Produto(int id, string nome, decimal preco)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome obrigatório");
            if (preco <= 0)
                throw new ArgumentException("Preço deve ser > 0");

            Id = id;
            Nome = nome;
            Preco = preco;
        }
    }
}
