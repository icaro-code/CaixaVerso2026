using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImpostoNF.Domain
{
    public class ItemNotaFiscal
    {
        public Produto Produto { get; }
        public int Quantidade { get; }

        public ItemNotaFiscal(Produto produto, int quantidade)
        {
            Produto = produto ?? throw new ArgumentNullException(nameof(produto));
            Quantidade = quantidade > 0 ? quantidade : throw new ArgumentException("Quantidade deve ser maior que zero");
        }

        public decimal Subtotal() => Produto.Preco * Quantidade;
    }

}
