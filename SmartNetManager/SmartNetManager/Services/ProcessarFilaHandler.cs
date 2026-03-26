using SmartNetManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class ProcessarFilaHandler : IActionHandler
    {
        private readonly AutenticacaoService autenticacao;
        private readonly DashBoardService dashboard;
        private readonly AuditoriaService auditoria;

        public ProcessarFilaHandler(AutenticacaoService autenticacao, DashBoardService dashboard, AuditoriaService auditoria)
        {
            this.autenticacao = autenticacao;
            this.dashboard = dashboard;
            this.auditoria = auditoria;
        }

        public void Executar()
        {
            var autenticado = autenticacao.ProcessarFila();
            if (autenticado != null)
            {
                dashboard.ConexoesAtivas.Add(autenticado);
                auditoria.Registrar($"Dispositivo {autenticado.Nome} autenticado.");
            }
        }
    }
}
