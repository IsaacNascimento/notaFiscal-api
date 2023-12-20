using Src.Api.Domain.Models.ProdutoModels;

namespace Src.Api.Application.Repository.ProdutoInterface
{
    public interface IProdutoInterface
    {
        public List<ProdutoModel> GetProdutos();
    }
}