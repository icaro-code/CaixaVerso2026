using ProjetoPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedidos.Domain.Pagamentos
{
    public class PagamentoPix : IPagamento
    {
        public string Nome => "Pix";
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"[Pix] Pago {valor:C}");
        }
    }
}
