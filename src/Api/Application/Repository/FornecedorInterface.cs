using Src.Api.Application.Dto.FornecedorDto;
using Src.Api.Domain.Models.FornecedorModels;

namespace Src.Api.Application.Repository.FornecedorInterface
{
    public interface IFornecedorInterface
    {
        public List<FornecedorModel> GetFornecedores();
        public string CriarFornecedor(CriarFornecedorDto criarFornecedorDto);
    }
}