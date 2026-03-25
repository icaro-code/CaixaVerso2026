using SmartNetManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class RelatorioService
    {
        public void ImprimirRelatorio(IEnumerable<Dispositivo> colecao)
        {
            foreach (var i in colecao)
            {
                System.Console.WriteLine($"{i.Nome} - {i.Fabricante} - {i.EnderecoIP} - {i.ConsumoBanda} Mbps");
            }
        }

    }
}
