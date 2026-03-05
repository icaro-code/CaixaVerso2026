using ProjetoPedidos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedidos.Domain.Interfaces
{
    public interface IDesconto
    {
        string Nome { get; }
        decimal CalcularDesconto(Pedido pedido);
    }
}
