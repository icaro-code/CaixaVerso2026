using Microsoft.Extensions.DependencyInjection;
using ProjetoPedidos.Application;
using ProjetoPedidos.Domain.Discounts;
using ProjetoPedidos.Domain.Entities;
using ProjetoPedidos.Domain.Interfaces;
using ProjetoPedidos.Domain.Pagamentos;
using ProjetoPedidos.Infrastructure.Logging;


var services = new ServiceCollection();

// Logger
services.AddSingleton<ILogger, ConsoleLogger>();

// Descontos
services.AddSingleton<IDesconto>(new DescontoPercentual(10));
services.AddSingleton<IDesconto>(new DescontoPorQuantidade(5, 20));

// Pagamento (pode trocar para Cartão aqui)
services.AddSingleton<IPagamento, PagamentoPix>();

// Processor
services.AddSingleton<PedidoProcessor>();

var provider = services.BuildServiceProvider();
var processor = provider.GetRequiredService<PedidoProcessor>();

// Cenário
var mouse = new Produto(1, "Mouse", 79.90m);
var teclado = new Produto(2, "Teclado", 159.90m);
var headset = new Produto(3, "Headset", 249.90m);

var pedido = new Pedido();
pedido.AdicionarItem(mouse, 2);
pedido.AdicionarItem(teclado, 1);
pedido.AdicionarItem(headset, 2);

processor.Processar(pedido);
