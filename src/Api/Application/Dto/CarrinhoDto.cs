namespace Src.Api.Application.Dto.CarrinhoDto
{
    public class CriarCarrinhoDto
    {
        public string? IdCarrinho { get; set; } = null;
        public int? Quantidade { get; set; } = null;
        public string? IdNota { get; set; } = null;
        public string? IdProduto { get; set; } = null;
    }
}