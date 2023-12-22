using Src.Api.Application.Repository.FornecedorInterface;
using Src.Api.Domain.Models.FornecedorModels;
using Src.Connection;

namespace Src.Api.Infrasctructure.Repository.FornecedorRepositories
{
    public class FornecedorRepository : IFornecedorInterface
    {
        private readonly NotaDbContext _context;

        public FornecedorRepository(NotaDbContext context)
        {
            _context = context;
        }

        public List<FornecedorModel> GetFornecedores()
        {
            try
            {
                List<FornecedorModel> fornecedores = _context.Fornecedor.ToList();
                return fornecedores;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao recuperar os fornecedores: {ex.Message}");
            }
        }
    }
}