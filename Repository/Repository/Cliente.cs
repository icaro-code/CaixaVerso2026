using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Cliente : IEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
    }

}
