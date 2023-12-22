using Microsoft.AspNetCore.Mvc;
using Src.Api.Application.Services.ClienteServices;
using Src.Api.Application.Services.FornecedorServices;
using Src.Api.Domain.Models.ClienteModels;
using Src.Api.Domain.Models.FornecedorModels;
using Src.Api.Infrasctructure.Repository.ClienteRepositories;
using Src.Api.Infrasctructure.Repository.FornecedorRepositories;
using Src.Connection;

namespace Src.Api.UI.Controllers.FornecedorControllers
{
    public class FornecedorController : Controller
    {
        private readonly NotaDbContext _context;
        public FornecedorController(NotaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("v1/fornecedores")]
        public IActionResult GetFornecedores()
        {
            try
            {
                FornecedorRepository fornecedorRepository = new FornecedorRepository(_context);
                FornecedorService fornecedorService = new FornecedorService(fornecedorRepository);
                List<FornecedorModel> fornecedores = fornecedorService.GetFornecedores();

                return Ok(new { fornecedores });

            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao recuperar os fornecedores: {ex.Message}");
            }
        }
    }
}