using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Src.Api.Domain.Models.CarrinhoModels;
using Src.Api.Domain.Models.FornecedorModels;

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

        public required string Cnpj { get; set; }
        public FornecedorModel Fornecedor { get; set; } = null!;
        public ICollection<CarrinhoModel> Carrinhos { get; set; } = new List<CarrinhoModel>();
    }
}