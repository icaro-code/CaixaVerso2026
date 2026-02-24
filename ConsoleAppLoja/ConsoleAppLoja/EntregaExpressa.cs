using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoja
{
    public class EntregaExpressa : EntregaBase
    {
        public EntregaExpressa(string endereco) : base(endereco) { }

        public override decimal CalcularFrete(decimal totalDoCarrinho)
        {
            decimal frete = totalDoCarrinho * 0.20m;
            if (frete < 30m) frete = 30m;
            return frete;
        }
    }
}
