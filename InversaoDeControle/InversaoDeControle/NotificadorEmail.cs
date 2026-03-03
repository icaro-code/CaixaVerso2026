using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoDeControle
{
    public class NotificadorEmail : INotificador
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"EMAIL: {mensagem}");
        }
    }
}
