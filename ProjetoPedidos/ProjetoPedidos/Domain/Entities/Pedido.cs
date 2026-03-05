using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entidade Pedido: mantém lista interna de itens e calcula totais

namespace ProjetoPedidos.Domain.Entities
{
    public class Pedido
    {
        private readonly List<ItemPedido> _itens = new();   // Campo somente leitura que inicializa a lista de itens do pedido
        public IReadOnlyCollection<ItemPedido> Itens => _itens.AsReadOnly();

        public void AdicionarItem(Produto produto, int quantidade)
        {
            _itens.Add(new ItemPedido(produto, quantidade));
        }

        public decimal TotalBruto() => _itens.Sum(i => i.Subtotal());
    }
}
