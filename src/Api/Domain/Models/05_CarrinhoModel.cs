using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Src.Api.Domain.Models.CarrinhoModels
{

    [Table("carrinho")]

    public class CarrinhoModel
    {
        [Key]
        public required string IdCarrinho { get; set; }

        [Required]
        public required int Quantidade { get; set; }
    }
}