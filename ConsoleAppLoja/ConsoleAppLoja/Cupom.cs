using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoja
{
    public class Cupom
    {
        public string Codigo { get; private set; }
        public decimal Percentual { get; private set; }

        public Cupom(string codigo, decimal percentual)
        {
            if (string.IsNullOrWhiteSpace(codigo)) throw new ArgumentException("Código é obrigatório.", nameof(codigo));
            if (percentual <= 0m || percentual >= 1m) throw new ArgumentException("Percentual deve estar entre 0 e 1 (ex.: 0,10 para 10%).", nameof(percentual));
            Codigo = codigo.Trim().ToUpperInvariant();
            Percentual = percentual;
        }

        public decimal CalcularDesconto(decimal valorBase)
        {
            if (valorBase <= 0m) return 0m;
            return valorBase * Percentual;
        }
    }

}
