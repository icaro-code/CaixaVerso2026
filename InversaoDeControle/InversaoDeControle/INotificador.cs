using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoDeControle
{
    public interface INotificador
    {
        void Enviar(string mensagem);
    }

}
