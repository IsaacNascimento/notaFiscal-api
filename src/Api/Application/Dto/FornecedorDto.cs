using Src.Api.Application.Dto.ProdutoDto;

namespace Src.Api.Application.Dto.FornecedorDto
{
    public class CriarFornecedorDto
    {
        public string? Nome { get; set; } = null;
        public string? IdNota { get; set; } = null;
        public List<CriarProdutoDto>? Produtos { get; set; } = null;
    }
}