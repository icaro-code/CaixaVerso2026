using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class PagamentoDebito : IPagamento
    {
        public string Nome => "Débito";

        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento no DÉBITO: R$ {valor:0.00}");
        }
    }
}
