using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace notaFiscal_api.Migrations
{
    /// <inheritdoc />
    public partial class _01_AdicionarRelacaoClienteNotaFiscal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Cpf = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Nome = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Cpf);
                });

            migrationBuilder.CreateTable(
                name: "notaFiscal",
                columns: table => new
                {
                    IdNota = table.Column<string>(type: "text", nullable: false),
                    ValorTotal = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    Cpf = table.Column<string>(type: "character varying(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notaFiscal", x => x.IdNota);
                    table.ForeignKey(
                        name: "FK_notaFiscal_cliente_Cpf",
                        column: x => x.Cpf,
                        principalTable: "cliente",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_notaFiscal_Cpf",
                table: "notaFiscal",
                column: "Cpf");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "notaFiscal");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
