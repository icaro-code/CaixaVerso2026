using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IPagamento
    {
        string Nome { get; }
        void Pagar(decimal valor);
    }

}
