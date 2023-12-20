using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Src.Api.Domain.Models.NotaFiscalModels
{

    [Table("notaFiscal")]

    public class NotaFiscalModel
    {
        [Key]
        public required string IdNota { get; set; }

        [Required]
        [StringLength(6)]
        public required string ValorTotal { get; set; }


    }
}