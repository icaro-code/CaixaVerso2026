using SmartNetManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class FirewallHandler : IActionHandler
    {
        private readonly FireWallService firewall;
        private readonly DashBoardService dashboard;
        private readonly AuditoriaService auditoria;

        public FirewallHandler(FireWallService firewall, DashBoardService dashboard, AuditoriaService auditoria)
        {
            this.firewall = firewall;
            this.dashboard = dashboard;
            this.auditoria = auditoria;
        }

        public void Executar()
        {
            firewall.AplicarFirewall(dashboard.ConexoesAtivas, d => d.Fabricante == "Apple");
            auditoria.Registrar("Firewall aplicado: bloqueio Apple.");
        }
    }
}
