using ProjetoPedidos.Domain.Entities;
using ProjetoPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedidos.Domain.Discounts
{
    public class DescontoPorQuantidade : IDesconto
    {
        public string Nome => "DescontoPorQuantidade";
        private readonly int _minItens;
        private readonly decimal _valor;

        public DescontoPorQuantidade(int minItens, decimal valor)
        {
            _minItens = minItens;
            _valor = valor;
        }

        public decimal CalcularDesconto(Pedido pedido)
        {
            int totalItens = pedido.Itens.Sum(i => i.Quantidade);
            return totalItens >= _minItens ? _valor : 0;
        }
    }

}
