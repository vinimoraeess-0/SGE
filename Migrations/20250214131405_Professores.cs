using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGE.Migrations
{
    /// <inheritdoc />
    public partial class Professores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProfessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpfProfessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailProfessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelProfessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NascimentoProfessor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
