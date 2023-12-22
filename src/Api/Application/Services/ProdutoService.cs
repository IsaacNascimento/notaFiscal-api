using Src.Api.Application.Dto.CarrinhoDto;
using Src.Api.Application.Dto.ProdutoDto;
using Src.Api.Application.Repository.ProdutoInterface;
using Src.Api.Domain.Models.ProdutoModels;

namespace Src.Api.Application.Services.ProdutoServices
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
        public string CriarProduto(CriarProdutoDto criarProdutoDto)
        {
            string message = _produtoInterface.CriarProduto(criarProdutoDto);
            return message;
        }
    }
}