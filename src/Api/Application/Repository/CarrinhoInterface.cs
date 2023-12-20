using Src.Api.Application.Dto.CarrinhoDto;
using Src.Api.Domain.Models.CarrinhoModels;
using Src.Api.Domain.Models.ClienteModels;

namespace Src.Api.Application.Repository.CarrinhoInterface
{
    public interface ICarrinhoInterface
    {
        public List<CarrinhoModel> GetCarrinhos();
        public string CriarCarrinho(CriarCarrinhoDto criarCarrinhoDto);
    }
}