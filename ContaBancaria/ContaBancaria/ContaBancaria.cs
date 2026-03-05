using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public abstract class ContaBancaria
    {
        public int Numero { get; }
        public string Titular { get; }
        public decimal Saldo { get; protected set; }
        protected List<Transacao> Historico { get; } = new();

        protected ContaBancaria(int numero, string titular, decimal saldoInicial)
        {
            if (string.IsNullOrWhiteSpace(titular))
                throw new ArgumentException("Titular obrigatório");
            if (saldoInicial < 0)
                throw new ArgumentException("Saldo inicial não pode ser negativo");

            Numero = numero;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0) throw new ArgumentException("Valor inválido");
            Saldo += valor;
            Historico.Add(new Transacao("Depósito", valor));
        }
        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0) throw new ArgumentException("Valor inválido");
            if (valor > Saldo) throw new InvalidOperationException("Saldo insuficiente");
            Saldo -= valor;
            Historico.Add(new Transacao("Saque", valor));
        }

        public void ExibirExtrato()
        {
            Console.WriteLine($"Extrato da conta {Numero} - Titular: {Titular}");
            foreach (var t in Historico)
                Console.WriteLine(t);
            Console.WriteLine($"Saldo atual: {Saldo:C}");
        }
    }

}
