using Src.Api.Application.Dto.ClienteDto;
using Src.Api.Domain.Models.ClienteModels;

namespace Src.Api.Application.Repository.ClienteInterface
{
    public interface IClienteInterface
    {
        public List<ClienteModel> GetClientes();
        public string CriarCliente(CriarClienteDto criarClienteDto);
    }
}