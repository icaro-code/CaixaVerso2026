using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImpostoNF.Domain
{
    public class NotaFiscal
    {
        private readonly List<ItemNotaFiscal> _itens = new List<ItemNotaFiscal>();

        public IReadOnlyList<ItemNotaFiscal> Itens => _itens.AsReadOnly();

        public void AdicionarItem(Produto produto, int quantidade)
        {
            _itens.Add(new ItemNotaFiscal(produto, quantidade));
        }

        public decimal TotalBruto()
        {
            decimal total = 0;
            foreach (var item in _itens)
            {
                total += item.Subtotal();
            }
            return total;
        }
        public void ExibirResumo()
        {
            Console.WriteLine("=== NOTA FISCAL ===");
            foreach (var item in _itens)
            {
                Console.WriteLine($"{item.Produto.Nome} x{item.Quantidade} = {item.Subtotal():N2}");
            }
            Console.WriteLine($"Total bruto: {TotalBruto():N2}");
        }
    }

}
