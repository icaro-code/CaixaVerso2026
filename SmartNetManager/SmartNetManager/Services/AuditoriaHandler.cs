using SmartNetManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class AuditoriaHandler : IActionHandler
    {
        private readonly AuditoriaService auditoria;

        public AuditoriaHandler(AuditoriaService auditoria) => this.auditoria = auditoria;

        public void Executar() => auditoria.DesfazerUltimaAcao();
    }
}
