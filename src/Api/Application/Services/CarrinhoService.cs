using Src.Api.Application.Dto.CarrinhoDto;
using Src.Api.Application.Repository.CarrinhoInterface;
using Src.Api.Domain.Models.CarrinhoModels;

namespace Src.Api.Application.Dto.CarrinhoServices
{
    public class CarrinhoService
    {
        private readonly ICarrinhoInterface _carrinhoInterface;
        public CarrinhoService(ICarrinhoInterface carrinhoInterface)
        {
            _carrinhoInterface = carrinhoInterface;
        }

        public List<CarrinhoModel> GetCarrinhos()
        {
            List<CarrinhoModel> carrinhos = _carrinhoInterface.GetCarrinhos();
            return carrinhos;
        }

        public string CriarCarrinho(CriarCarrinhoDto criarCarrinhoDto)
        {
            string message = _carrinhoInterface.CriarCarrinho(criarCarrinhoDto);
            return message;
        }
    }
}