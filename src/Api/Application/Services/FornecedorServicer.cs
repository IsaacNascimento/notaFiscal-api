using Src.Api.Application.Dto.FornecedorDto;
using Src.Api.Application.Repository.FornecedorInterface;
using Src.Api.Domain.Models.FornecedorModels;

namespace Src.Api.Application.Services.FornecedorServices
{
    public class FornecedorService
    {
        private readonly IFornecedorInterface _fornecedorInterface;
        public FornecedorService(IFornecedorInterface fornecedorInterface)
        {
            _fornecedorInterface = fornecedorInterface;
        }

        public List<FornecedorModel> GetFornecedores()
        {
            List<FornecedorModel> fornecedores = _fornecedorInterface.GetFornecedores();
            return fornecedores;
        }
        public string CriarFornecedor(CriarFornecedorDto criarFornecedorDto)
        {
            string message = _fornecedorInterface.CriarFornecedor(criarFornecedorDto);
            return message;
        }
    }
}