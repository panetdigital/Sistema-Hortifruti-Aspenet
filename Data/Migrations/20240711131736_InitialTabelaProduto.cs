using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovoProjetoFrutas.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialTabelaProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrecoPromo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Grupo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstoqueDisponivel = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Cod", "CodItem", "EstoqueDisponivel", "Grupo", "Imagem", "Link", "Nome", "Preco", "PrecoPromo" },
                values: new object[] { 1, "192", "1922", 100, "legume", "\"https:\\/\\/www.nagumo.com.br\\/sao-paulo-lj17-pires-do-rio-jardim-lideranca-avenida-pires-do-rio\\/produto\\/abobora-------------------------moranga", "\"https:\\/\\/www.nagumo.com.br\\/sao-paulo-lj17-pires-do-rio-jardim-lideranca-avenida-pires-do-rio\\/produto\\/abobora-------------------------moranga", "Abóbora Moranga", 5m, 4m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
