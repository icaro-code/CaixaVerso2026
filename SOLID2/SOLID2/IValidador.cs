using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{
    public interface IValidador<T>
    {
        bool Validar(T entidade);
    }
}
