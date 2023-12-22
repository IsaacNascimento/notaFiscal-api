using Microsoft.AspNetCore.Mvc;
using Src.Api.Application.Dto.ClienteDto;
using Src.Api.Application.Services.ClienteServices;
using Src.Api.Domain.Models.ClienteModels;
using Src.Api.Infrasctructure.Repository.ClienteRepositories;
using Src.Connection;

namespace Src.Api.UI.Controllers.ClienteControllers
{
    public class ClienteController : Controller
    {
        private readonly NotaDbContext _context;
        public ClienteController(NotaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("v1/clientes")]
        public IActionResult GetClientes()
        {
            try
            {
                ClienteRepository clienteRepository = new ClienteRepository(_context);
                ClienteService clienteService = new ClienteService(clienteRepository);
                List<ClienteModel> clientes = clienteService.GetClientes();

                return Ok(new { clientes });

            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao recuperar os clientes: {ex.Message}");
            }
        }
        [HttpPost]
        [Route("v1/clientes")]
        public IActionResult CriarCliente([FromBody] CriarClienteDto criarClienteDto)
        {
            try
            {
                ClienteRepository clienteRepository = new ClienteRepository(_context);
                ClienteService clienteService = new ClienteService(clienteRepository);
                string message = clienteService.CriarCliente(criarClienteDto);

                return Ok(new { message });

            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao recuperar os clientes: {ex.Message}");
            }
        }
    }
}