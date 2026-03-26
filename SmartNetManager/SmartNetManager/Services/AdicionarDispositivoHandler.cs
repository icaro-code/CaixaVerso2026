using SmartNetManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class AdicionarDispositivoHandler : IActionHandler
    {
        private readonly AutenticacaoService autenticacao;

        public AdicionarDispositivoHandler(AutenticacaoService autenticacao) => this.autenticacao = autenticacao;

        public void Executar()
        {
            var dispositivo = new Dispositivo
            {
                MacAddress = Guid.NewGuid().ToString().Substring(0, 12),
                EnderecoIP = "0.0.0.0",
                Nome = "NovoDispositivo",
                Fabricante = "Dell",
                ConsumoBanda = new Random().Next(10, 600),
                DataConexao = DateTime.Now
            };
            autenticacao.AdicionarFila(dispositivo);
        }
    }
}
