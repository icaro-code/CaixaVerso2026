using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoDeControle
{
    public class NotificadorSms : INotificador
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"SMS: {mensagem}");
        }
    }
}
