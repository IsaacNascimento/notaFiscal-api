using Microsoft.AspNetCore.Mvc;
using Src.Api.Application.Dto.NotaFiscalDto;
using Src.Api.Application.Services.NotaFicalServices;
using Src.Api.Domain.Models.NotaFiscalModels;
using Src.Api.Infrasctructure.Repository.NotaFiscalRepositories;
using Src.Connection;

namespace Src.Api.UI.Controllers.NotaFiscalControllers
{
    public class NotaFiscalController : Controller
    {
        private readonly NotaDbContext _context;
        public NotaFiscalController(NotaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("v1/notasFiscais")]
        public IActionResult GetNotasFiscais()
        {
            try
            {
                NotaFiscalRepository notaFiscalRepository = new NotaFiscalRepository(_context);
                NotaFiscalService notaFiscalService = new NotaFiscalService(notaFiscalRepository);
                List<NotaFiscalModel> notas = notaFiscalService.GetNotasFicais();

                return Ok(new { notas });
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao recuperar os notas: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("v1/notaFiscais")]
        public IActionResult CriarNotaFiscal([FromBody] EmitirNotaFiscalDto emitirNotaFiscalDto)
        {
            try
            {
                NotaFiscalRepository notaFiscalRepository = new NotaFiscalRepository(_context);
                NotaFiscalService notaFiscalService = new NotaFiscalService(notaFiscalRepository);
                string message = notaFiscalService.EmitirNota(emitirNotaFiscalDto);

                return Ok(new { message });
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao criar um novo carrinho: {ex.Message}");
            }
        }
    }
}