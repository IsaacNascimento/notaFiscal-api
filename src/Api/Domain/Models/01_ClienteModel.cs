using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Src.Api.Domain.Models.NotaFiscalModels;

namespace Src.Api.Domain.Models.ClienteModels
{

    [Table("cliente")]

    public class ClienteModel
    {
        [Key]
        [Required(ErrorMessage = "O campo Cpf é obrigatório.")]
        [StringLength(15, ErrorMessage = "O campo Cpf deve ter no máximo 15 caracteres.")]
        public required string Cpf { get; set; }

        [Required]
        [StringLength(30)]
        public required string Nome { get; set; }

        public virtual ICollection<NotaFiscalModel> NotasFiscais { get; set; } = new List<NotaFiscalModel>();
    }
}