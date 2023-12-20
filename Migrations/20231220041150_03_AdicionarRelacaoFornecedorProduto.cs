using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace notaFiscal_api.Migrations
{
    /// <inheritdoc />
    public partial class _03_AdicionarRelacaoFornecedorProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    IdProduto = table.Column<string>(type: "text", nullable: false),
                    Nome = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Descricao = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    Valor = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    Cnpj = table.Column<string>(type: "character varying(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.IdProduto);
                    table.ForeignKey(
                        name: "FK_produto_fornecedor_Cnpj",
                        column: x => x.Cnpj,
                        principalTable: "fornecedor",
                        principalColumn: "Cnpj",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_produto_Cnpj",
                table: "produto",
                column: "Cnpj");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produto");
        }
    }
}
