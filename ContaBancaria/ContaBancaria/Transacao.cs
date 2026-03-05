using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Transacao
    {
        public DateTime Data { get; }
        public string Tipo { get; }
        public decimal Valor { get; }

        public Transacao(string tipo, decimal valor)
        {
            Data = DateTime.Now;
            Tipo = tipo;
            Valor = valor;
        }

        public override string ToString() => $"{Data:dd/MM/yyyy HH:mm} - {Tipo}: {Valor:C}";
    }

}
