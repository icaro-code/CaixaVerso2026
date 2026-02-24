using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoja
{
    public class EntregaNormal : EntregaBase
    {
        public EntregaNormal(string endereco) : base(endereco) { }

        public override decimal CalcularFrete(decimal totalDoCarrinho)
        {
            decimal frete = totalDoCarrinho * 0.10m;
            if (frete < 15m) frete = 15m;
            return frete;
        }
    }
}
