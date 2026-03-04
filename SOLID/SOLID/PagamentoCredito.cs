using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class PagamentoCredito : IPagamento
    {
        public string Nome => "Crédito";

        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento no CRÉDITO: R$ {valor:0.00}");
        }
    }
}
