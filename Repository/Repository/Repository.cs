using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<T> where T : IEntidade
    {
        private readonly List<T> _entidades = new List<T>();

        public void Adicionar(T entidade)
        {
            _entidades.Add(entidade);
        }

        public T? ObterPorId(int id)
        {
            return _entidades.Find(e => e.Id == id);
        }

        public List<T> ObterTodos()
        {
            return new List<T>(_entidades);
        }

        public void Remover(int id)
        {
            var entidade = ObterPorId(id);
            if (entidade != null)
            {
                _entidades.Remove(entidade);
            }
        }
    }

}
