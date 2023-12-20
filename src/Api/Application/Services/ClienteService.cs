using Src.Api.Application.Repository.ClienteInterface;
using Src.Api.Domain.Models.ClienteModels;

namespace Src.Api.Application.Dto.ClienteServices
{
    public class ClienteService
    {
        private readonly IClienteInterface _clienteInterface;
        public ClienteService(IClienteInterface clienteInterface)
        {
            _clienteInterface = clienteInterface;
        }

        public List<ClienteModel> GetClientes()
        {
            List<ClienteModel> clientes = _clienteInterface.GetClientes();
            return clientes;
        }
    }
}