using Src.Api.Application.Dto.ProdutoDto;

namespace Src.Api.Application.Dto.FornecedorDto
{
    public class CriarFornecedorDto
    {
        public required string Cnpj { get; set; }
        public required string Nome { get; set; }
        public required string IdNota { get; set; }
    }
}