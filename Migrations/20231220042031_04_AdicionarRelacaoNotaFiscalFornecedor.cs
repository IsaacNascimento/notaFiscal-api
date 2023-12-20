using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace notaFiscal_api.Migrations
{
    /// <inheritdoc />
    public partial class _04_AdicionarRelacaoNotaFiscalFornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carrinho",
                columns: table => new
                {
                    IdCarrinho = table.Column<string>(type: "text", nullable: false),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    IdNota = table.Column<string>(type: "text", nullable: false),
                    ProdutoModelIdProduto = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carrinho", x => x.IdCarrinho);
                    table.ForeignKey(
                        name: "FK_carrinho_notaFiscal_IdNota",
                        column: x => x.IdNota,
                        principalTable: "notaFiscal",
                        principalColumn: "IdNota",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_carrinho_produto_ProdutoModelIdProduto",
                        column: x => x.ProdutoModelIdProduto,
                        principalTable: "produto",
                        principalColumn: "IdProduto");
                });

            migrationBuilder.CreateIndex(
                name: "IX_carrinho_IdNota",
                table: "carrinho",
                column: "IdNota");

            migrationBuilder.CreateIndex(
                name: "IX_carrinho_ProdutoModelIdProduto",
                table: "carrinho",
                column: "ProdutoModelIdProduto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carrinho");
        }
    }
}
