using ProjetoPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedidos.Domain.Pagamentos  // Define o namespace onde ficam as classes relacionadas a pagamentos
{
    public class PagamentoPix : IPagamento  // Declara a classe PagamentoPix que implementa a interface IPagamento
    {
        public string Nome => "Pix";
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"[Pix] Pago {valor:C}");
        }
    }
}
