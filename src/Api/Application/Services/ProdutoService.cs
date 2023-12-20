using Src.Api.Application.Repository.ProdutoInterface;
using Src.Api.Domain.Models.ProdutoModels;

namespace Src.Api.Application.Dto.ProdutoServices
{
    public class ProdutoService
    {
        private readonly IProdutoInterface _produtoInterface;
        public ProdutoService(IProdutoInterface produtoInterface)
        {
            _produtoInterface = produtoInterface;
        }

        public List<ProdutoModel> GetProdutos()
        {
            List<ProdutoModel> produtos = _produtoInterface.GetProdutos();
            return produtos;
        }
    }
}