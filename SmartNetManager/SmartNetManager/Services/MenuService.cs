using SmartNetManager.Utils;
using SmartNetManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class MenuService
    {
        private readonly MenuPrinter printer;
        private readonly Dictionary<int, IActionHandler> handlers;

        public MenuService(
            DhcpService dhcp,
            AutenticacaoService autenticacao,
            DashBoardService dashboard,
            FireWallService firewall,
            RelatorioService relatorio,
            AuditoriaService auditoria)
        {
            printer = new MenuPrinter();

            handlers = new Dictionary<int, IActionHandler>
            {
                {1, new DhcpHandler(dhcp)},
                {2, new AdicionarDispositivoHandler(autenticacao)},
                {3, new ProcessarFilaHandler(autenticacao, dashboard, auditoria)},
                {4, new DashboardHandler(dashboard)},
                {5, new RelatorioHandler(relatorio, autenticacao, dashboard)},
                {6, new FirewallHandler(firewall, dashboard, auditoria)},
                {7, new AuditoriaHandler(auditoria)}
            };
        }
        public void Executar()
        {
            int opcao;
            do
            {
                printer.ExibirMenu();
                opcao = int.Parse(Console.ReadLine());

                if (handlers.ContainsKey(opcao))
                    handlers[opcao].Executar();

            } while (opcao != 0);
        }
    }
}
