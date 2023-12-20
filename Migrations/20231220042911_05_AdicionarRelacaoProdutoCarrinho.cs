using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace notaFiscal_api.Migrations
{
    /// <inheritdoc />
    public partial class _05_AdicionarRelacaoProdutoCarrinho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carrinho_produto_ProdutoModelIdProduto",
                table: "carrinho");

            migrationBuilder.DropIndex(
                name: "IX_carrinho_ProdutoModelIdProduto",
                table: "carrinho");

            migrationBuilder.DropColumn(
                name: "ProdutoModelIdProduto",
                table: "carrinho");

            migrationBuilder.AddColumn<string>(
                name: "IdProduto",
                table: "carrinho",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_carrinho_IdProduto",
                table: "carrinho",
                column: "IdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_carrinho_produto_IdProduto",
                table: "carrinho",
                column: "IdProduto",
                principalTable: "produto",
                principalColumn: "IdProduto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carrinho_produto_IdProduto",
                table: "carrinho");

            migrationBuilder.DropIndex(
                name: "IX_carrinho_IdProduto",
                table: "carrinho");

            migrationBuilder.DropColumn(
                name: "IdProduto",
                table: "carrinho");

            migrationBuilder.AddColumn<string>(
                name: "ProdutoModelIdProduto",
                table: "carrinho",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_carrinho_ProdutoModelIdProduto",
                table: "carrinho",
                column: "ProdutoModelIdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_carrinho_produto_ProdutoModelIdProduto",
                table: "carrinho",
                column: "ProdutoModelIdProduto",
                principalTable: "produto",
                principalColumn: "IdProduto");
        }
    }
}
