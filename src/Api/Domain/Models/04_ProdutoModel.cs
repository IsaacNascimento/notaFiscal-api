using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Src.Api.Domain.Models.ProdutoModels
{

    [Table("produto")]

    public class ProdutoModel
    {
        [Key]
        public required string IdProduto { get; set; }

        [Required]
        [StringLength(20)]
        public required string Nome { get; set; }

        [StringLength(40)]
        public required string Descricao { get; set; }

        [Required]
        [StringLength(6)]
        public required string Valor { get; set; }
    }
}