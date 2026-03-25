using SmartNetManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class AutenticacaoService
    {
        public Queue<Dispositivo> FilaAutenticacao { get; private set; } = new Queue<Dispositivo>();

        public void AdicionarFila(Dispositivo dispositivo)
        {
            FilaAutenticacao.Enqueue(dispositivo);
            System.Console.WriteLine($"Dispositivo {dispositivo.Nome} adicionado à fila.");
        }

        public Dispositivo ProcessarFila()
        {
            if (FilaAutenticacao.Count > 0)
            {
                var dispositivo = FilaAutenticacao.Dequeue();
                System.Console.WriteLine($"Dispositivo {dispositivo.Nome} autenticado.");
                return dispositivo;
            }
            System.Console.WriteLine("Fila vazia.");
            return null;
        }
    }
}
