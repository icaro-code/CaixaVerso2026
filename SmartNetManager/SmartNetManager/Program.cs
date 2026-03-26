using SmartNetManager.Services;
using SmartNetManager.Models;
using SmartNetManager.Utils;
using System;

namespace SmartNetManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var dhcp = new DhcpService();
            var autenticacao = new AutenticacaoService();
            var dashboard = new DashBoardService();
            var firewall = new FireWallService();
            var relatorio = new RelatorioService();
            var auditoria = new AuditoriaService();

            var menu = new MenuService(dhcp, autenticacao, dashboard, firewall, relatorio, auditoria);
            menu.Executar();
        }
    }
}