using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{
    public interface IRepository<T>
    {
        void Inserir(T entidade);
        IEnumerable<T> Listar();
    }
}
