using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoDeControle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Execução usando NotificadorEmail
            INotificador notificadorEmail = new NotificadorEmail();
            ContaService contaEmail = new ContaService(notificadorEmail);
            contaEmail.CriarConta("Maria", "maria@email.com");

            // Execução usando NotificadorSms
            INotificador notificadorSms = new NotificadorSms();
            ContaService contaSms = new ContaService(notificadorSms);
            contaSms.CriarConta("João", "joao@sms.com");
        }
    }
}
