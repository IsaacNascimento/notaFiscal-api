using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Src.Api.Domain.Models.CarrinhoModels;
using Src.Api.Domain.Models.ClienteModels;
using Src.Api.Domain.Models.FornecedorModels;

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

        public ICollection<FornecedorModel> Fornecedores { get; set; } = new List<FornecedorModel>();

        public ICollection<CarrinhoModel> Carrinhos { get; set; } = new List<CarrinhoModel>();

    }
}