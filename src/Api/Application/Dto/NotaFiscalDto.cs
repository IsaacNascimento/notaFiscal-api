using Src.Api.Application.Dto.CarrinhoDto;
using Src.Api.Application.Dto.FornecedorDto;

namespace Src.Api.Application.Dto.NotaFiscalDto
{
    public class EmitirNotaFiscalDto
    {
        public required string IdNota { get; set; }
        public required string ValorTotal { get; set; }
        public required string ClienteCpf { get; set; }
    }
}