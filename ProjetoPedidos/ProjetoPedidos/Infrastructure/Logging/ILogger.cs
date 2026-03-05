using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Interface de logging: abstrai registro de mensagens

namespace ProjetoPedidos.Infrastructure.Logging
{
    public interface ILogger    // Define uma interface para abstrair operações de logging
    {
        void Info(string message);
        void Error(string message);
    }
}
