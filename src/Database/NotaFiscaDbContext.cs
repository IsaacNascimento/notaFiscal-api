using Microsoft.EntityFrameworkCore;
using Src.Api.Domain.Models.ClienteModels;
using Src.Api.Domain.Models.FornecedorModels;
using Src.Api.Domain.Models.NotaFiscalModels;


namespace Src.Connection
{

    public class NotaDbContext : DbContext
    {
        public NotaDbContext(DbContextOptions<NotaDbContext> options) : base(options)
        {
        }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<NotaFiscalModel> Notas { get; set; }
        public DbSet<FornecedorModel> Fornecedores { get; set; }
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
        }
    }
}