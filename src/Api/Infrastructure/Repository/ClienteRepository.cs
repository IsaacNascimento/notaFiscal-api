using Microsoft.EntityFrameworkCore;
using Src.Api.Application.Repository.ClienteInterface;
using Src.Api.Domain.Models.ClienteModels;
using Src.Connection;

namespace Src.Api.Infrasctructure.Repository.ClienteRepositories
{
    public class ClienteRepository : IClienteInterface
    {
        private readonly NotaDbContext _context;

        public ClienteRepository(NotaDbContext context)
        {
            _context = context;
        }

        public List<ClienteModel> GetClientes()
        {
            try
            {
                List<ClienteModel> clientes = _context.Cliente.ToList();
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao recuperar os clientes: {ex.Message}");
            }
        }
    }
}