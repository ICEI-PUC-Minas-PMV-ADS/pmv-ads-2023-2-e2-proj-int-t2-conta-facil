using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContaFacil2.Migrations
{
    public partial class M02AddTableSaldo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Saldos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    Resumo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo_Saldo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saldos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Saldos");
        }
    }
}
