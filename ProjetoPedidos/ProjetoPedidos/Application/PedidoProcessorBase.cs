using ProjetoPedidos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedidos.Application
{
    public abstract class PedidoProcessorBase
    {
        public void Processar(Pedido pedido)
        {
            ValidarPedido(pedido);
            var bruto = CalcularTotalBruto(pedido);
            var descontos = CalcularDescontos(pedido);
            var final = CalcularTotalFinal(bruto, descontos);
            RealizarPagamento(final);
            RegistrarLog(bruto, descontos, final);
        }

        protected abstract void ValidarPedido(Pedido pedido);
        protected abstract decimal CalcularTotalBruto(Pedido pedido);
        protected abstract decimal CalcularDescontos(Pedido pedido);
        protected abstract decimal CalcularTotalFinal(decimal bruto, decimal descontos);
        protected abstract void RealizarPagamento(decimal valorFinal);
        protected abstract void RegistrarLog(decimal bruto, decimal descontos, decimal final);
    }
}
