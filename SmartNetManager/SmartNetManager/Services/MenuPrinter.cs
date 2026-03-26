using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class MenuPrinter
    {
        public void ExibirMenu()
        {
            Console.WriteLine("\n=== SmartNet Manager ===");
            Console.WriteLine("1 - Reservar IP (DHCP)");
            Console.WriteLine("2 - Adicionar dispositivo à fila");
            Console.WriteLine("3 - Processar fila (Autenticar)");
            Console.WriteLine("4 - Exibir Dashboard");
            Console.WriteLine("5 - Imprimir Relatório");
            Console.WriteLine("6 - Aplicar Firewall");
            Console.WriteLine("7 - Desfazer última ação");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
        }
    }
}
