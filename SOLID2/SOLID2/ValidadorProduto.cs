using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{
    public class ValidadorProduto : IValidador<Produto>
    {
        public bool Validar(Produto produto)
        {
            return !string.IsNullOrWhiteSpace(produto.Descricao) && produto.ValorUnitario > 0;
        }
    }
}
