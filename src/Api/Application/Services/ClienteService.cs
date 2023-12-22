using Src.Api.Application.Dto.ClienteDto;
using Src.Api.Application.Repository.ClienteInterface;
using Src.Api.Domain.Models.ClienteModels;

namespace Src.Api.Application.Services.ClienteServices
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
        public string CriarCliente(CriarClienteDto criarClienteDto)
        {
            string message = _clienteInterface.CriarCliente(criarClienteDto);
            return message;
        }
    }
}