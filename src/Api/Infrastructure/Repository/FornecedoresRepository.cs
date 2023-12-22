using Src.Api.Application.Dto.FornecedorDto;
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
        public string CriarFornecedor(CriarFornecedorDto criarFornecedorDto)
        {
            try
            {
                FornecedorModel fornecedorModel = new FornecedorModel
                {
                    Cnpj = criarFornecedorDto.Cnpj,
                    Nome = criarFornecedorDto.Nome,
                    IdNota = criarFornecedorDto.IdNota
                };

                _context.Fornecedor.Add(fornecedorModel);
                _context.SaveChanges();

                return "Fornecedor criar com sucesso!";
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao criar um fornecedor: {ex.Message}");
            }
        }
    }
}