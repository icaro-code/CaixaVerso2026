using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedidos.Infrastructure.Repository
{
    public interface IEntity
    {
        int Id { get; }
    }

    public interface IRepository<T> where T : IEntity
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
    }

    public class InMemoryRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _data = new();

        public void Add(T entity) => _data.Add(entity);

        public IEnumerable<T> GetAll() => _data;
    }

}
