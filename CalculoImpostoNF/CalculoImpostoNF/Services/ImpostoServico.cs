using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImpostoNF.Services
{
    public class ImpostoServico : ImpostoBase
    {
        public override decimal Calcular(decimal valor) => valor * 0.12m;
    }

}
