using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Src.Api.Domain.Models.NotaFiscalModels;
using Src.Api.Domain.Models.ProdutoModels;

namespace Src.Api.Domain.Models.CarrinhoModels
{

    [Table("carrinho")]

    public class CarrinhoModel
    {
        [Key]
        public required string IdCarrinho { get; set; }

        [Required]
        public required int Quantidade { get; set; }
        public required string IdNota { get; set; }
        public NotaFiscalModel NotaFiscal { get; set; } = null!;
        public required string IdProduto { get; set; }
        public ProdutoModel Produto { get; set; } = null!;
    }
}