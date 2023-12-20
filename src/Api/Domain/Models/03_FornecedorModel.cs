using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Src.Api.Domain.Models.NotaFiscalModels;
using Src.Api.Domain.Models.ProdutoModels;

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

        public required string IdNota { get; set; }
        public NotaFiscalModel NotaFiscal { get; set; } = null!;

        public ICollection<ProdutoModel> Produtos { get; set; } = new List<ProdutoModel>();
    }
}