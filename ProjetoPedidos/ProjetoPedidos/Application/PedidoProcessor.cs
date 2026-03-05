using ProjetoPedidos.Domain.Entities;
using ProjetoPedidos.Domain.Interfaces;
using ProjetoPedidos.Infrastructure.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedidos.Application
{
    public class PedidoProcessor : PedidoProcessorBase
    {
        private readonly IEnumerable<IDesconto> _descontos;
        private readonly IPagamento _pagamento;
        private readonly ILogger _logger;

        public PedidoProcessor(IEnumerable<IDesconto> descontos, IPagamento pagamento, ILogger logger)
        {
            _descontos = descontos;
            _pagamento = pagamento;
            _logger = logger;
        }

        protected override void ValidarPedido(Pedido pedido)
        {
            if (!pedido.Itens.Any())
                throw new InvalidOperationException("Pedido vazio");
        }
        protected override decimal CalcularTotalBruto(Pedido pedido) => pedido.TotalBruto();

        protected override decimal CalcularDescontos(Pedido pedido)
        {
            decimal total = 0;
            foreach (var d in _descontos)
            {
                var valor = d.CalcularDesconto(pedido);
                if (valor > 0)
                    _logger.Info($"- {d.Nome}: {valor:C}");
                total += valor;
            }
            return total;
        }
        protected override decimal CalcularTotalFinal(decimal bruto, decimal descontos)
              => bruto - descontos;

        protected override void RealizarPagamento(decimal valorFinal)
            => _pagamento.Pagar(valorFinal);

        protected override void RegistrarLog(decimal bruto, decimal descontos, decimal final)
        {
            _logger.Info($"Total bruto: {bruto:C}");
            _logger.Info($"Total descontos: {descontos:C}");
            _logger.Info($"Total final: {final:C}");
            _logger.Info($"Pagamento: {_pagamento.Nome}");
            _logger.Info("Status: Pago com sucesso");
        }
    }
}
