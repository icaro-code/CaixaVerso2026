using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class DhcpHandler : IActionHandler
    {
        private readonly DhcpService dhcp;

        public DhcpHandler(DhcpService dhcp) => this.dhcp = dhcp;

        public void Executar()
        {
            Console.Write("MAC Address: ");
            string mac = Console.ReadLine();
            Console.Write("IP: ");
            string ip = Console.ReadLine();
            dhcp.ReservarIP(mac, ip);
        }
    }
}
