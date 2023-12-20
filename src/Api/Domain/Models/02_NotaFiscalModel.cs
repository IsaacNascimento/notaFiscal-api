using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Src.Api.Domain.Models.ClienteModels;

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

        public required string Cpf { get; set; }
        public ClienteModel Cliente { get; set; } = null!;

    }
}