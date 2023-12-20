using Src.Api.Application.Dto.CarrinhoDto;
using Src.Api.Domain.Models.CarrinhoModels;
using Src.Api.Domain.Models.ClienteModels;

namespace Src.Api.Application.Repository.CarrinhoInterface
{
    public interface ICarrinhoInterface
    {
        public List<CarrinhoModel> Carrinhos();
        public string CriarCarrinho(CriarCarrinhoDto criarCarrinhoDto);
    }
}