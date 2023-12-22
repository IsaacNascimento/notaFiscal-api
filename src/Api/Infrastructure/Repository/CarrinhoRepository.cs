using Src.Api.Application.Dto.CarrinhoDto;
using Src.Api.Application.Repository.CarrinhoInterface;
using Src.Api.Domain.Models.CarrinhoModels;
using Src.Connection;

namespace Src.Api.Infrasctructure.Repository.CarrinhoRepositories
{
    public class CarrinhoRepository : ICarrinhoInterface
    {
        private readonly NotaDbContext _context;

        public CarrinhoRepository(NotaDbContext context)
        {
            _context = context;
        }

        public string CriarCarrinho(CriarCarrinhoDto criarCarrinhoDto)
        {
            try
            {
                CarrinhoModel carrinhoModel = new CarrinhoModel
                {
                    IdCarrinho = criarCarrinhoDto.IdCarrinho,
                    Quantidade = criarCarrinhoDto.Quantidade,
                    IdNota = criarCarrinhoDto.IdNota,
                    IdProduto = criarCarrinhoDto.IdProduto,
                };

                Console.WriteLine("----------------------");
                Console.WriteLine($"Carrinho DTO: {carrinhoModel}");
                Console.WriteLine("----------------------");

                _context.Carrinho.Add(carrinhoModel);
                _context.SaveChanges();

                return "Carrinho criado com sucesso";

            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao criar um novo carrinho: {ex.Message}");
            }
        }

        public List<CarrinhoModel> GetCarrinhos()
        {
            try
            {
                List<CarrinhoModel> carrinhos = _context.Carrinho.ToList();
                return carrinhos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um Erro ao recuperar os carrinhos: {ex.Message}");
            }
        }
    }
}