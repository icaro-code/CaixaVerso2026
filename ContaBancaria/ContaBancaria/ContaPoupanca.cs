using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, string titular, decimal saldoInicial)
            : base(numero, titular, saldoInicial) { }

        // Exemplo de polimorfismo: rendimento
        public void RenderJuros(decimal percentual)
        {
            var rendimento = Saldo * percentual;
            Saldo += rendimento;
            Historico.Add(new Transacao("Rendimento", rendimento));
        }
    }

}
