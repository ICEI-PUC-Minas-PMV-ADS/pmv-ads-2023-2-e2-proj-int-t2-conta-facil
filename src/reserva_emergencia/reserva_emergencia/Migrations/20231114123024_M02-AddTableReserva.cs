using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reserva_emergencia.Migrations
{
    public partial class M02AddTableReserva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salario = table.Column<double>(type: "float", nullable: false),
                    totalEssenciais = table.Column<double>(type: "float", nullable: false),
                    totalNaoEssenciais = table.Column<double>(type: "float", nullable: false),
                    investimento = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
