using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class DashboardHandler : IActionHandler
    {
        private readonly DashBoardService dashboard;

        public DashboardHandler(DashBoardService dashboard) => this.dashboard = dashboard;

        public void Executar() => dashboard.ExibirDashboard();
    }
}
