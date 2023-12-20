using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace notaFiscal_api.Migrations
{
    /// <inheritdoc />
    public partial class _02_AdicionarRelacaoNotaFiscalFornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fornecedor",
                columns: table => new
                {
                    Cnpj = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Nome = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    IdNota = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor", x => x.Cnpj);
                    table.ForeignKey(
                        name: "FK_fornecedor_notaFiscal_IdNota",
                        column: x => x.IdNota,
                        principalTable: "notaFiscal",
                        principalColumn: "IdNota",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_fornecedor_IdNota",
                table: "fornecedor",
                column: "IdNota");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fornecedor");
        }
    }
}
