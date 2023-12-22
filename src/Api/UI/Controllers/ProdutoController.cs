using Microsoft.AspNetCore.Mvc;
using Src.Api.Application.Services.ProdutoServices;
using Src.Api.Domain.Models.ProdutoModels;
using Src.Api.Infrasctructure.Repository.ProdutoRepositories;
using Src.Connection;

namespace Src.Api.UI.Controllers.ProdutoControllers
{
    public class ProdutoController : Controller
    {
        private readonly NotaDbContext _context;
        public ProdutoController(NotaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("v1/produtos")]
        public IActionResult GetProdutos()
        {
            try
            {
                ProdutoRepository produtoRepository = new ProdutoRepository(_context);
                ProdutoService produtoService = new ProdutoService(produtoRepository);
                List<ProdutoModel> produtos = produtoService.GetProdutos();

                return Ok(new { produtos });

            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao recuperar os produtos: {ex.Message}");
            }
        }
    }
}