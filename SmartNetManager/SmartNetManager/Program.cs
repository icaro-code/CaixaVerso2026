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

            int opcao;
            do
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
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("MAC Address: ");
                        string mac = Console.ReadLine();
                        Console.Write("IP: ");
                        string ip = Console.ReadLine();
                        dhcp.ReservarIP(mac, ip);
                        break;

                    case 2:
                        var dispositivo = new Dispositivo
                        {
                            MacAddress = Guid.NewGuid().ToString().Substring(0, 12),
                            EnderecoIP = "0.0.0.0",
                            Nome = "NovoDispositivo",
                            Fabricante = "Dell",
                            ConsumoBanda = new Random().Next(10, 600),
                            DataConexao = DateTime.Now
                        };
                        autenticacao.AdicionarFila(dispositivo);
                        break;

                    case 3:
                        var autenticado = autenticacao.ProcessarFila();
                        if (autenticado != null)
                        {
                            dashboard.ConexoesAtivas.Add(autenticado);
                            auditoria.Registrar($"Dispositivo {autenticado.Nome} autenticado.");
                        }
                        break;

                    case 4:
                        dashboard.ExibirDashboard();
                        break;

                    case 5:
                        Console.WriteLine("Relatório da Fila:");
                        relatorio.ImprimirRelatorio(autenticacao.FilaAutenticacao);
                        Console.WriteLine("Relatório dos Ativos:");
                        relatorio.ImprimirRelatorio(dashboard.ConexoesAtivas);
                        break;

                    case 6:
                        firewall.AplicarFirewall(dashboard.ConexoesAtivas, d => d.Fabricante == "Apple");
                        auditoria.Registrar("Firewall aplicado: bloqueio Apple.");
                        break;

                    case 7:
                        auditoria.DesfazerUltimaAcao();
                        break;
                }

            } while (opcao != 0);
        }
    }
}
