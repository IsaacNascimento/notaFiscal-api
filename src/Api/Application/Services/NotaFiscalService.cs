using Src.Api.Application.Dto.NotaFiscalDto;
using Src.Api.Application.Repository.NotaFiscalInterface;
using Src.Api.Domain.Models.NotaFiscalModels;

namespace Src.Api.Application.Services.NotaFicalServices
{
    public class NotaFicalService
    {
        private readonly INotaFiscalInterface _notaFiscalInterface;
        public NotaFicalService(INotaFiscalInterface notaFiscalInterface)
        {
            _notaFiscalInterface = notaFiscalInterface;
        }

        public List<NotaFiscalModel> GetNotasFicais()
        {
            List<NotaFiscalModel> notasFiscais = _notaFiscalInterface.GetNotasFiscais();
            return notasFiscais;
        }

        public string EmitirNota(EmitirNotaFiscalDto emitirNotaFiscalDto)
        {
            string message = _notaFiscalInterface.EmitirNota(emitirNotaFiscalDto);
            return message;
        }
    }
}