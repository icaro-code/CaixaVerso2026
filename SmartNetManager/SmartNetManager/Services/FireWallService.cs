using SmartNetManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class FireWallService
    {
        public void AplicarFirewall(List<Dispositivo> ativos, Func<Dispositivo, bool> regraBloqueio)
        {
            ativos.RemoveAll(d => regraBloqueio(d));
            Console.WriteLine("Firewall aplicado.");
        }
    }
}
