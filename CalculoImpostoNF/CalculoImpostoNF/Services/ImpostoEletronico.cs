using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImpostoNF.Services
{
    public class ImpostoEletronico : ImpostoBase
    {
        public override decimal Calcular(decimal valor)
        {
            // Bônus 1 — faixa acima de 1000
            if (valor > 1000) return valor * 0.18m;
            return valor * 0.15m;
        }
    }

}
