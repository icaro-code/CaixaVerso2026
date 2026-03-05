using ProjetoPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedidos.Domain.Pagamentos
{
    public class PagamentoCartao : IPagamento
    {
        public string Nome => "Cartão";
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"[Cartão] Pago {valor:C}");
        }
    }

}
