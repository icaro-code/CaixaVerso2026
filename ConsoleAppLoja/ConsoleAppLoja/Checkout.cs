using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoja
{
    public class Checkout
    {
        private readonly Carrinho _carrinho;
        private readonly EntregaBase _entrega;
        private readonly Cupom _cupom;

        public Checkout(Carrinho carrinho, EntregaBase entrega, Cupom cupom = null)
        {
            _carrinho = carrinho ?? throw new ArgumentNullException(nameof(carrinho));
            _entrega = entrega ?? throw new ArgumentNullException(nameof(entrega));
            _cupom = cupom;
        }

        public void Finalizar()
        {
            decimal totalCarrinho = _carrinho.Total();
            decimal desconto = _cupom != null ? _cupom.CalcularDesconto(totalCarrinho) : 0m;
            decimal totalAposDesconto = totalCarrinho - desconto;
            if (totalAposDesconto < 0m) totalAposDesconto = 0m;
            decimal frete = _entrega.CalcularFrete(totalAposDesconto);
            decimal totalGeral = totalAposDesconto + frete;

            Console.WriteLine("=== Checkout ===");
            Console.WriteLine($"Total do carrinho: R$ {totalCarrinho:F2}");
            if (_cupom != null) Console.WriteLine($"Cupom {_cupom.Codigo}: -R$ {desconto:F2}");
            Console.WriteLine($"Frete: R$ {frete:F2}");
            Console.WriteLine($"Total geral: R$ {totalGeral:F2}");
            Console.WriteLine($"Endereço de entrega: {_entrega.Endereco}");
        }
    }
}
