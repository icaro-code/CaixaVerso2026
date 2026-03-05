using ProjetoPedidos.Domain.Entities;
using ProjetoPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProjetoPedidos.Domain.Discounts
{
    // Desconto percentual: aplica % sobre o total bruto
    public class DescontoPercentual : IDesconto
    {
        public string Nome => $"DescontoPercentual ({_percentual}%)";
        private readonly decimal _percentual;

        public DescontoPercentual(decimal percentual)
        {
            _percentual = percentual;
        }

        public decimal CalcularDesconto(Pedido pedido)
            => pedido.TotalBruto() * _percentual / 100;
    }

}
