using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{
    public interface IRepositoryGuid<T>
    {
        T BuscarPorId(Guid id);
        void Atualizar(Guid id, T entidade);
    }
}
