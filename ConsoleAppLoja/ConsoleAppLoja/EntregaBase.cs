using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoja
{
    public class EntregaBase
    {
        public string Endereco { get; private set; }

        public EntregaBase(string endereco)
        {
            if (string.IsNullOrWhiteSpace(endereco)) throw new ArgumentException("Endereço é obrigatório.", nameof(endereco));
            Endereco = endereco.Trim();
        }

        public virtual decimal CalcularFrete(decimal totalDoCarrinho)
        {
            if (totalDoCarrinho < 0m) totalDoCarrinho = 0m;
            return 0m;
        }
    }
}
