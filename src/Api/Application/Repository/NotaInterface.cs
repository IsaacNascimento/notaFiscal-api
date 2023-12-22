using Src.Api.Application.Dto.NotaFiscalDto;
using Src.Api.Domain.Models.NotaFiscalModels;

namespace Src.Api.Application.Repository.NotaFiscalInterface
{
    public interface INotaFiscalInterface
    {
        public List<NotaFiscalModel> GetNotasFiscais();
        public string EmitirNota(EmitirNotaFiscalDto emitirNotaFiscalDto);
    }
}