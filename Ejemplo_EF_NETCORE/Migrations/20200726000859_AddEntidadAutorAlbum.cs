using Microsoft.EntityFrameworkCore.Migrations;

namespace Ejemplo_EF_NETCORE.Migrations
{
    public partial class AddEntidadAutorAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Canciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Canciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_albums", x => x.AlbumId);
                });

            migrationBuilder.CreateTable(
                name: "autor",
                columns: table => new
                {
                    AutorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autor", x => x.AutorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_AlbumId",
                table: "Canciones",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_AutorId",
                table: "Canciones",
                column: "AutorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_albums_AlbumId",
                table: "Canciones",
                column: "AlbumId",
                principalTable: "albums",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_autor_AutorId",
                table: "Canciones",
                column: "AutorId",
                principalTable: "autor",
                principalColumn: "AutorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_albums_AlbumId",
                table: "Canciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_autor_AutorId",
                table: "Canciones");

            migrationBuilder.DropTable(
                name: "albums");

            migrationBuilder.DropTable(
                name: "autor");

            migrationBuilder.DropIndex(
                name: "IX_Canciones_AlbumId",
                table: "Canciones");

            migrationBuilder.DropIndex(
                name: "IX_Canciones_AutorId",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Canciones");
        }
    }
}
