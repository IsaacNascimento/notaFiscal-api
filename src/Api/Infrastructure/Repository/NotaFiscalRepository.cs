using Src.Api.Application.Dto.CarrinhoDto;
using Src.Api.Application.Dto.NotaFiscalDto;
using Src.Api.Application.Repository.NotaFiscalInterface;
using Src.Api.Domain.Models.CarrinhoModels;
using Src.Api.Domain.Models.NotaFiscalModels;
using Src.Connection;

namespace Src.Api.Infrasctructure.Repository.NotaFiscalRepositories
{
    public class NotaFiscalRepository : INotaFiscalInterface
    {
        private readonly NotaDbContext _context;

        public NotaFiscalRepository(NotaDbContext context)
        {
            _context = context;
        }

        public string EmitirNota(EmitirNotaFiscalDto EmitirNotaFiscalDto)
        {
            try
            {
                return "Nota criado com sucesso";
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao criar um novo carrinho: {ex.Message}");
            }
        }

        public List<NotaFiscalModel> GetNotasFiscais()
        {
            try
            {
                List<NotaFiscalModel> notas = _context.Nota.ToList();
                return notas;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao recuperar os notasFiscais: {ex.Message}");
            }
        }
    }
}