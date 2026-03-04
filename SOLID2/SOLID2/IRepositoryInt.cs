using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{
    public interface IRepositoryInt<T>
    {
        T BuscarPorId(int id);
        void Atualizar(int id, T entidade);
    }
}
