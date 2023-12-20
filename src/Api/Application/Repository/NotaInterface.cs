using Src.Api.Application.Dto.NotaFiscalDto;
using Src.Api.Domain.Models.NotaFiscalModels;
using Src.Api.Domain.Models.ProdutoModels;

namespace Src.Api.Application.Repository.NotaFiscalInterface
{
    public interface INotaFiscalInterface
    {
        public List<NotaFiscalModel> GetNotasFiscais();
        public string EmitirNota(EmitirNotaFiscalDto emitirNotaFiscalDto);
    }
}