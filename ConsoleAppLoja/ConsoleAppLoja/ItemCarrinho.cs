using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoja
{
    public class ItemCarrinho
    {
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }

        public ItemCarrinho(Produto produto, int quantidade)
        {
            if (produto == null) throw new ArgumentNullException(nameof(produto));
            if (quantidade < 1) throw new ArgumentException("Quantidade deve ser >= 1.", nameof(quantidade));
            Produto = produto;
            Quantidade = quantidade;
        }

        public void AdicionarQuantidade(int quantidade)
        {
            if (quantidade < 1) throw new ArgumentException("Quantidade deve ser >= 1.", nameof(quantidade));
            Quantidade += quantidade;
        }

        public decimal Subtotal()
        {
            return Produto.Preco * Quantidade;
        }
    }
}