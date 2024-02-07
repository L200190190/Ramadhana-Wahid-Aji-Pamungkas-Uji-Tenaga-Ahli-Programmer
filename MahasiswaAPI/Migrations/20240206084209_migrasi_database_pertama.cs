using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MahasiswaAPI.Migrations
{
    /// <inheritdoc />
    public partial class migrasi_database_pertama : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_M_Mahasiswa",
                columns: table => new
                {
                    Nobp = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nohp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JenisKelamin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_M_Mahasiswa", x => x.Nobp);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_M_Mahasiswa");
        }
    }
}
