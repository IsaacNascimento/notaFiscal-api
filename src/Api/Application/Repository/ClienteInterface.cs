using Src.Api.Domain.Models.ClienteModels;

namespace Src.Api.Application.Repository.ClienteInterface
{
    public interface IClienteInterface
    {
        public List<ClienteModel> Clientes();
    }
}