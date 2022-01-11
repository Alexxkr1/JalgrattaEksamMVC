using Microsoft.EntityFrameworkCore.Migrations;

namespace JalgrattaEksamMVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eksam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eesnimi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Perekonnanimi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Teooria = table.Column<int>(type: "int", nullable: false),
                    Slaloom = table.Column<int>(type: "int", nullable: false),
                    Ring = table.Column<int>(type: "int", nullable: false),
                    Tänav = table.Column<int>(type: "int", nullable: false),
                    Luba = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eksam", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eksam_Eesnimi_Perekonnanimi",
                table: "Eksam",
                columns: new[] { "Eesnimi", "Perekonnanimi" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eksam");
        }
    }
}
