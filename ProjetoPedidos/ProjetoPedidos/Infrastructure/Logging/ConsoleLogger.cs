using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Implementação simples de logger: escreve mensagens no console

namespace ProjetoPedidos.Infrastructure.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Info(string message) => Console.WriteLine(message);
        public void Error(string message) => Console.WriteLine($"[ERROR] {message}");
    }
}
