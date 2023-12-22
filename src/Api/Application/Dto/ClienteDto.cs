using Src.Api.Application.Dto.NotaFiscalDto;

namespace Src.Api.Application.Dto.ClienteDto
{
    public class CriarClienteDto
    {
        public string? Cpf { get; set; } = null;
        public string? Nome { get; set; } = null;
        public List<EmitirNotaFiscalDto>? NotasFiscais { get; set; } = null;
    }
}