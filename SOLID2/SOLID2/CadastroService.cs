using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{
    public class CadastroService
    {
        private readonly IRepository<Produto> _repoProduto;
        private readonly IRepositoryGuid<Produto> _repoProdutoGuid;
        private readonly IRepository<NotaFiscal> _repoNotaFiscal;
        private readonly IRepositoryInt<NotaFiscal> _repoNotaFiscalInt;
        private readonly ILogger _logger;
        private readonly IValidador<Produto> _validadorProduto;

        public CadastroService(
            IRepository<Produto> repoProduto,
            IRepositoryGuid<Produto> repoProdutoGuid,
            IRepository<NotaFiscal> repoNotaFiscal,
            IRepositoryInt<NotaFiscal> repoNotaFiscalInt,
            ILogger logger,
            IValidador<Produto> validadorProduto)
        {
            _repoProduto = repoProduto;
            _repoProdutoGuid = repoProdutoGuid;
            _repoNotaFiscal = repoNotaFiscal;
            _repoNotaFiscalInt = repoNotaFiscalInt;
            _logger = logger;
            _validadorProduto = validadorProduto;
        }

        public void CadastrarProduto(Produto produto)
        {
            if (_validadorProduto.Validar(produto))
            {
                _repoProduto.Inserir(produto);
                _logger.Log($"Produto cadastrado: {produto.Descricao}");
            }
            else
            {
                _logger.Log("Produto inválido, não cadastrado.");
            }
        }

        public void CadastrarNotaFiscal(NotaFiscal nf)
        {
            _repoNotaFiscal.Inserir(nf);
            _logger.Log($"Nota fiscal cadastrada: {nf.Numero} - Cliente {nf.Cliente}");
        }

        public void ListarProdutos()
        {
            foreach (var p in _repoProduto.Listar())
                Console.WriteLine($"Produto: {p.Descricao}, Valor: {p.ValorUnitario}");
        }

        public void ListarNotas()
        {
            foreach (var nf in _repoNotaFiscal.Listar())
                Console.WriteLine($"NF: {nf.Numero}, Cliente: {nf.Cliente}, Valor: {nf.ValorTotal}");
        }
    }
}
