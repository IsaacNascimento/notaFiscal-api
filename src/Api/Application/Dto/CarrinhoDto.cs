namespace Src.Api.Application.Dto.CarrinhoDto
{
    public class CriarCarrinhoDto
    {
        public required string IdCarrinho { get; set; }
        public required int Quantidade { get; set; }
        public required string IdNota { get; set; }
        public required string IdProduto { get; set; }
    }
}