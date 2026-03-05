using CalculoImpostoNF.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImpostoNF.Services
{
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

        // Relatório detalhado por categoria
        public Dictionary<CategoriaProduto, decimal> CalcularImpostosPorCategoria(NotaFiscal nota)
        {
            var resultado = new Dictionary<CategoriaProduto, decimal>
        {
            { CategoriaProduto.Alimento, 0 },
            { CategoriaProduto.Eletronico, 0 },
            { CategoriaProduto.Servico, 0 }
        };

            foreach (var item in nota.Itens)
            {
                decimal imposto = item.Produto.Categoria switch
                {
                    CategoriaProduto.Alimento => new ImpostoAlimento().Calcular(item.Subtotal()),
                    CategoriaProduto.Eletronico => new ImpostoEletronico().Calcular(item.Subtotal()),
                    CategoriaProduto.Servico => new ImpostoServico().Calcular(item.Subtotal()),
                    _ => 0
                };

                resultado[item.Produto.Categoria] += imposto;
            }

            return resultado;
        }
    }
}
