using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedidos.Domain.Entities
{
    public class ItemPedido
    {
        public Produto Produto { get; }
        public int Quantidade { get; }

        public ItemPedido(Produto produto, int quantidade)
        {
            if (quantidade < 1)
                throw new ArgumentException("Quantidade deve ser >= 1");

            Produto = produto;
            Quantidade = quantidade;
        }

        public decimal Subtotal() => Produto.Preco * Quantidade;
    }
}
