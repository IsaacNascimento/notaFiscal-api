using Src.Api.Application.Dto.CarrinhoDto;
using Src.Api.Application.Dto.FornecedorDto;

namespace Src.Api.Application.Dto.ProdutoDto
{
    public class CriarProdutoDto
    {
        public string? Nome { get; set; } = null;
        public string? Descricao { get; set; } = null;
        public string? Valor { get; set; } = null;
        public string? Cnpj { get; set; } = null;
        public List<CriarCarrinhoDto>? Carrinhos { get; set; } = null;
    }
}