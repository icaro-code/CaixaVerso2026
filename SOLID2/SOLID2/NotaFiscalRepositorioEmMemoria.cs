using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{
    public class NotaFiscalRepositorioEmMemoria : IRepository<NotaFiscal>, IRepositoryInt<NotaFiscal>
    {
        private readonly List<NotaFiscal> _notas = new();

        public void Inserir(NotaFiscal entidade) => _notas.Add(entidade);

        public IEnumerable<NotaFiscal> Listar() => _notas;

        public NotaFiscal BuscarPorId(int id) => _notas.FirstOrDefault(n => n.Numero == id);

        public void Atualizar(int id, NotaFiscal entidade)
        {
            var index = _notas.FindIndex(n => n.Numero == id);
            if (index >= 0) _notas[index] = entidade;
        }
    }
}
