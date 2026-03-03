using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoDeControle
{
    public class ContaService
    {
        private readonly INotificador _notificador;

        // IoC: recebe a dependência via construtor
        public ContaService(INotificador notificador)
        {
            _notificador = notificador;
        }

        public void CriarConta(string nome, string email)
        {
            string mensagem = $"Conta criada para {nome} ({email})";
            _notificador.Enviar(mensagem);
        }
    }
}
