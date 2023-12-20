using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Src.Api.Domain.Models.FornecedorModels
{

    [Table("fornecedor")]

    public class FornecedorModel
    {
        [Key]
        [Required(ErrorMessage = "O campo Cnpj é obrigatório.")]
        [StringLength(20, ErrorMessage = "O campo Cnpj deve ter no máximo 15 caracteres.")]
        public required string Cnpj { get; set; }

        [StringLength(30)]
        public required string Nome { get; set; }
    }
}