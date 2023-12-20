using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Src.Api.Domain.Models.NotaFiscalModels;

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
    }
}