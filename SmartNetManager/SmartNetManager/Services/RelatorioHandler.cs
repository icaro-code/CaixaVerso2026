using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class RelatorioHandler : IActionHandler
    {
        private readonly RelatorioService relatorio;
        private readonly AutenticacaoService autenticacao;
        private readonly DashBoardService dashboard;

        public RelatorioHandler(RelatorioService relatorio, AutenticacaoService autenticacao, DashBoardService dashboard)
        {
            this.relatorio = relatorio;
            this.autenticacao = autenticacao;
            this.dashboard = dashboard;
        }

        public void Executar()
        {
            Console.WriteLine("Relatório da Fila:");
            relatorio.ImprimirRelatorio(autenticacao.FilaAutenticacao);
            Console.WriteLine("Relatório dos Ativos:");
            relatorio.ImprimirRelatorio(dashboard.ConexoesAtivas);
        }
    }
}
