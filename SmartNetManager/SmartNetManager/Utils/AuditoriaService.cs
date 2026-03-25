using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Utils
{
    internal class AuditoriaService
    {
        private Stack<string> historico = new Stack<string>();

        public void Registrar(string acao)
        {
            historico.Push(acao);
            Console.WriteLine($"Ação registrada: {acao}");
        }

        public void DesfazerUltimaAcao()
        {
            if (historico.Count > 0)
            {
                var acao = historico.Pop();
                Console.WriteLine($"Última ação desfeita: {acao}");
            }
            else
            {
                Console.WriteLine("Nenhuma ação para desfazer.");
            }
        }

    }
}
