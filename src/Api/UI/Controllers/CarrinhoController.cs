using Microsoft.AspNetCore.Mvc;
using Src.Api.Application.Dto.CarrinhoDto;
using Src.Api.Application.Services.CarrinhoServices;
using Src.Api.Domain.Models.CarrinhoModels;
using Src.Api.Infrasctructure.Repository.CarrinhoRepositories;
using Src.Connection;

namespace Src.Api.UI.Controllers.CarrinhoControllers
{
    public class CarrinhoController : Controller
    {
        private readonly NotaDbContext _context;
        public CarrinhoController(NotaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("v1/carrinhos")]
        public IActionResult GetClientes()
        {
            try
            {
                CarrinhoRepository carrinhoRepository = new CarrinhoRepository(_context);
                CarrinhoService carrinhoService = new CarrinhoService(carrinhoRepository);
                List<CarrinhoModel> carrinhos = carrinhoService.GetCarrinhos();

                return Ok(new { carrinhos });
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao recuperar os carrinhos: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("v1/carrinhos")]
        public IActionResult CriarCarrinho([FromBody] CriarCarrinhoDto criarCarrinhoDto)
        {
            try
            {
                CarrinhoRepository carrinhoRepository = new CarrinhoRepository(_context);
                CarrinhoService carrinhoService = new CarrinhoService(carrinhoRepository);
                string message = carrinhoService.CriarCarrinho(criarCarrinhoDto);

                return Ok(new { message });
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao criar um novo carrinho: {ex.Message}");
            }
        }
    }
}