using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImpostoNF
{
    public abstract class ImpostoBase
    {
        public abstract decimal Calcular(decimal valor);
    }

    // Impostos concretos
    public class ImpostoAlimento : ImpostoBase
    {
        public override decimal Calcular(decimal valor) => valor * 0.05m;
    }

}
