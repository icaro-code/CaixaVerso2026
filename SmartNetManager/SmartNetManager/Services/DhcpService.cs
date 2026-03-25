using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class DhcpService
    {
        private Dictionary<string, string> reservas = new Dictionary<string, string>();

        public void ReservarIP(string mac, string ip)
        {
            if (!reservas.ContainsKey(mac))
            {
                reservas.Add(mac, ip);
                Console.WriteLine($"IP {ip} reservado para {mac}");
            }
            else
            {
                Console.WriteLine("MAC já possui reserva.");
            }
        }
    }
}
