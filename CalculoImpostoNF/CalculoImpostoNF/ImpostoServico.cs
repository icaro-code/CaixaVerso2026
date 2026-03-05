using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImpostoNF
{
    public class ImpostoServico : ImpostoBase
    {
        public override decimal Calcular(decimal valor) => valor * 0.12m;
    }

    // Calculadora de impostos
    public class CalculadoraImpostos
    {
        public decimal CalcularTotalImpostos(NotaFiscal nota, List<ImpostoBase> impostos)
        {
            decimal totalImpostos = 0;
            foreach (var item in nota.Itens)
            {
                foreach (var imposto in impostos)
                {
                    totalImpostos += imposto.Calcular(item.Subtotal());
                }
            }
            return totalImpostos;
        }
    }

}
