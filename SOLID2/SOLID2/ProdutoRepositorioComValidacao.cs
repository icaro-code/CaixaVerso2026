using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{
    public class ProdutoRepositorioComValidacao : IRepository<Produto>, IRepositoryGuid<Produto>
    {
        private readonly List<Produto> _produtos = new();

        public void Inserir(Produto entidade)
        {
            if (string.IsNullOrWhiteSpace(entidade.Descricao))
            {
                Console.WriteLine("Produto inválido: descrição vazia.");
                return;
            }
            _produtos.Add(entidade);
        }

        public IEnumerable<Produto> Listar() => _produtos;

        public Produto BuscarPorId(Guid id) => _produtos.FirstOrDefault(p => p.Id == id);

        public void Atualizar(Guid id, Produto entidade)
        {
            var index = _produtos.FindIndex(p => p.Id == id);
            if (index >= 0) _produtos[index] = entidade;
        }
    }

}
