using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numero, string titular, decimal saldoInicial)
            : base(numero, titular, saldoInicial) { }

        // Exemplo de polimorfismo: taxa de saque
        public override void Sacar(decimal valor)
        {
            decimal taxa = 1.50m;
            base.Sacar(valor + taxa);
            Historico.Add(new Transacao("Taxa de saque", taxa));
        }
    }

}
