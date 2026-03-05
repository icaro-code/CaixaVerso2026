using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class BancoService
    {
        private readonly List<ContaBancaria> _contas = new();

        public void AdicionarConta(ContaBancaria conta) => _contas.Add(conta);

        public ContaBancaria? BuscarConta(int numero) => _contas.Find(c => c.Numero == numero);
    }

}
