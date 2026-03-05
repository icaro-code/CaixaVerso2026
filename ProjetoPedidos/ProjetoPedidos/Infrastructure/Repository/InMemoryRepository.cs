using System;
using System.Collections.Generic;
using System.Linq;  // Importa funcionalidades de consulta LINQ para coleções
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedidos.Infrastructure.Repository
{
    // Interface de entidade: garante que todas tenham Id

    public interface IEntity
    {
        int Id { get; }
    }
    // Interface genérica de repositório: abstrai persistência em memória

    public interface IRepository<T> where T : IEntity   // Define uma interface genérica de repositório para tipos que implementam IEntity
    {
        void Add(T entity);
        IEnumerable<T> GetAll();    // Método que retorna todos os itens do tipo T em forma de coleção
    }

    // Implementação em memória do repositório genérico
    public class InMemoryRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _data = new();

        public void Add(T entity) => _data.Add(entity);

        public IEnumerable<T> GetAll() => _data;
    }

}
