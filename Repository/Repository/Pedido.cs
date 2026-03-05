using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Pedido : IEntidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
    }

}
