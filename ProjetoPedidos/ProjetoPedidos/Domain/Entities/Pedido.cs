using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedidos.Domain.Entities
{
    public class Pedido
    {
        private readonly List<ItemPedido> _itens = new();
        public IReadOnlyCollection<ItemPedido> Itens => _itens.AsReadOnly();

        public void AdicionarItem(Produto produto, int quantidade)
        {
            _itens.Add(new ItemPedido(produto, quantidade));
        }

        public decimal TotalBruto() => _itens.Sum(i => i.Subtotal());
    }
}
