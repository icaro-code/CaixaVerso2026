using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class CarrinhoDeCompras
    {
        public decimal ValorTotal { get; private set; }
        private List<string> itens = new List<string>();

        public void AdicionarProduto(string descricao, decimal valorUnitario, int quantidade)
        {
            ValorTotal += valorUnitario * quantidade;
            itens.Add($"{descricao} x{quantidade}");
        }

        public IEnumerable<string> GetItens() => itens;
    }
}
