using Src.Api.Application.Dto.CarrinhoDto;
using Src.Api.Application.Dto.FornecedorDto;

namespace Src.Api.Application.Dto.NotaFiscalDto
{
    public class EmitirNotaFiscalDto
    {
        public double? ValorTotal { get; set; } = null;
        public string? ClienteCpf { get; set; } = null;
        public List<CriarCarrinhoDto>? Carrinhos { get; set; } = null;
        public List<CriarFornecedorDto>? Fornecedores { get; set; } = null;
    }
}