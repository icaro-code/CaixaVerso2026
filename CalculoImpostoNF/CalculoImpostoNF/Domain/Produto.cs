using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImpostoNF.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public CategoriaProduto Categoria { get; set; }

        public Produto(int id, string nome, decimal preco, CategoriaProduto categoria)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome obrigatório");
            if (preco <= 0)
                throw new ArgumentException("Preço deve ser maior que zero");

            Id = id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }
    }

}
