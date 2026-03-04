using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Pagamento
    {
        public void Processar(TipoPagamento tipoPagamento, decimal valor)
        {
            switch (tipoPagamento)
            {
                case TipoPagamento.Debito:
                    Console.WriteLine($"Pagamento no DÉBITO: R$ {valor:0.00}");
                    break;
                case TipoPagamento.Credito:
                    Console.WriteLine($"Pagamento no CRÉDITO: R$ {valor:0.00}");
                    break;
                case TipoPagamento.Pix:
                    Console.WriteLine($"Pagamento no PIX: R$ {valor:0.00}");
                    break;
                default:
                    Console.WriteLine("Forma inválida!");
                    break;
            }
        }
    }
}
