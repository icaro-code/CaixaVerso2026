using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoja
{
    public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }

        public Produto(int id, string nome, decimal preco)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("Nome é obrigatório.", nameof(nome));
            if (preco <= 0m) throw new ArgumentException("Preço deve ser maior que zero.", nameof(preco));
            Id = id;
            Nome = nome.Trim();
            Preco = preco;
        }
    }
}
