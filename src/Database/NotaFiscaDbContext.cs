using Microsoft.EntityFrameworkCore;
using Src.Api.Domain.Models.CarrinhoModels;
using Src.Api.Domain.Models.ClienteModels;
using Src.Api.Domain.Models.FornecedorModels;
using Src.Api.Domain.Models.NotaFiscalModels;
using Src.Api.Domain.Models.ProdutoModels;


namespace Src.Connection
{

    public class NotaDbContext : DbContext
    {
        public NotaDbContext(DbContextOptions<NotaDbContext> options) : base(options)
        {
        }
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<NotaFiscalModel> Nota { get; set; }
        public DbSet<FornecedorModel> Fornecedor { get; set; }
        public DbSet<ProdutoModel> Produto { get; set; }
        public DbSet<CarrinhoModel> Carrinho { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteModel>()
                .HasMany(e => e.NotasFiscais)
                .WithOne(e => e.Cliente)
                .HasForeignKey(e => e.Cpf)
                .IsRequired();

            modelBuilder.Entity<NotaFiscalModel>()
                .HasMany(e => e.Fornecedores)
                .WithOne(e => e.NotaFiscal)
                .HasForeignKey(e => e.IdNota)
                .IsRequired();

            modelBuilder.Entity<FornecedorModel>()
                .HasMany(e => e.Produtos)
                .WithOne(e => e.Fornecedor)
                .HasForeignKey(e => e.Cnpj)
                .IsRequired();

            modelBuilder.Entity<NotaFiscalModel>()
                .HasMany(e => e.Carrinhos)
                .WithOne(e => e.NotaFiscal)
                .HasForeignKey(e => e.IdNota)
                .IsRequired();

            modelBuilder.Entity<ProdutoModel>()
                .HasMany(e => e.Carrinhos)
                .WithOne(e => e.Produto)
                .HasForeignKey(e => e.IdProduto)
                .IsRequired();
        }
    }
}