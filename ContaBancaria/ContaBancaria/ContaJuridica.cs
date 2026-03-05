using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaJuridica : ContaBancaria
    {
        public string CNPJ { get; }

        public ContaJuridica(int numero, string titular, decimal saldoInicial, string cnpj)
            : base(numero, titular, saldoInicial)
        {
            if (string.IsNullOrWhiteSpace(cnpj))
                throw new ArgumentException("CNPJ obrigatório");
            CNPJ = cnpj;
        }

        // Sobrescrevendo saque com taxa maior
        public override void Sacar(decimal valor)
        {
            decimal taxa = 5.00m; // taxa fixa para conta jurídica
            base.Sacar(valor + taxa);
            Historico.Add(new Transacao("Taxa de saque (jurídica)", taxa));
        }

        // Método exclusivo da conta jurídica
        public void SolicitarEmprestimo(decimal valor)
        {
            if (valor <= 0) throw new ArgumentException("Valor inválido");
            Saldo += valor;
            Historico.Add(new Transacao("Empréstimo concedido", valor));
        }
    }

}
