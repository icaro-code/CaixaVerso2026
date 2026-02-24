using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoja
{
    public class Carrinho
    {
        private readonly List<ItemCarrinho> _itens = new List<ItemCarrinho>();

        public void Adicionar(Produto produto)
        {
            Adicionar(produto, 1);
        }

        public void Adicionar(Produto produto, int quantidade)
        {
            if (produto == null) throw new ArgumentNullException(nameof(produto));
            if (quantidade < 1) throw new ArgumentException("Quantidade deve ser >= 1.", nameof(quantidade));

            ItemCarrinho existente = null;
            for (int i = 0; i < _itens.Count; i++)
            {
                if (_itens[i].Produto.Id == produto.Id)
                {
                    existente = _itens[i];
                    break;
                }
            }

            if (existente != null)
            {
                existente.AdicionarQuantidade(quantidade);
            }
            else
            {
                _itens.Add(new ItemCarrinho(produto, quantidade));
            }
        }

        public void Adicionar(params Produto[] produtos)
        {
            if (produtos == null) throw new ArgumentNullException(nameof(produtos));
            for (int i = 0; i < produtos.Length; i++)
            {
                Adicionar(produtos[i], 1);
            }
        }

        public void Remover(int produtoId)
        {
            int index = -1;
            for (int i = 0; i < _itens.Count; i++)
            {
                if (_itens[i].Produto.Id == produtoId)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                _itens.RemoveAt(index);
            }
        }

        public decimal Total()
        {
            decimal total = 0m;
            for (int i = 0; i < _itens.Count; i++)
            {
                total += _itens[i].Subtotal();
            }
            return total;
        }

        public void ExibirResumo()
        {
            Console.WriteLine("=== Itens do Carrinho ===");
            for (int i = 0; i < _itens.Count; i++)
            {
                var item = _itens[i];
                Console.WriteLine($"{item.Produto.Nome} (x{item.Quantidade}) - Unitário: R$ {item.Produto.Preco:F2} | Subtotal: R$ {item.Subtotal():F2}");
            }
            Console.WriteLine($"Total: R$ {Total():F2}");
        }
    }
}
