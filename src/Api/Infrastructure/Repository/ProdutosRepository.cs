using Src.Api.Application.Dto.ProdutoDto;
using Src.Api.Application.Repository.ProdutoInterface;
using Src.Api.Domain.Models.ProdutoModels;
using Src.Connection;

namespace Src.Api.Infrasctructure.Repository.ProdutoRepositories
{
    public class ProdutoRepository : IProdutoInterface
    {
        private readonly NotaDbContext _context;

        public ProdutoRepository(NotaDbContext context)
        {
            _context = context;
        }

        public List<ProdutoModel> GetProdutos()
        {
            try
            {
                List<ProdutoModel> produtos = _context.Produto.ToList();
                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao recuperar os produtos: {ex.Message}");
            }
        }
        public string CriarProduto(CriarProdutoDto criarProdutoDto)
        {
            try
            {
                ProdutoModel produtoModel = new ProdutoModel
                {
                    IdProduto = criarProdutoDto.IdProduto,
                    Nome = criarProdutoDto.Nome,
                    Descricao = criarProdutoDto.Descricao,
                    Valor = criarProdutoDto.Valor,
                    Cnpj = criarProdutoDto.Cnpj
                };

                _context.Produto.Add(produtoModel);
                _context.SaveChanges();

                return "Produto criado com sucesso!";
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao recuperar os produtos: {ex.Message}");
            }
        }
    }
}