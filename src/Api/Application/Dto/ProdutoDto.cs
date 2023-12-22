
namespace Src.Api.Application.Dto.ProdutoDto
{
    public class CriarProdutoDto
    {
        public required string IdProduto { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public required string Valor { get; set; }
        public required string Cnpj { get; set; }
    }
}