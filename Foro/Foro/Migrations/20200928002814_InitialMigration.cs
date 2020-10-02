using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Foro.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    GrupoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activo = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.GrupoID);
                });

            migrationBuilder.CreateTable(
                name: "Publicaciones",
                columns: table => new
                {
                    PublicacionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    Contenido = table.Column<string>(nullable: true),
                    GrupoID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicaciones", x => x.PublicacionID);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Grupos_GrupoID",
                        column: x => x.GrupoID,
                        principalTable: "Grupos",
                        principalColumn: "GrupoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    ComentarioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    PublicacionID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.ComentarioID);
                    table.ForeignKey(
                        name: "FK_Comentarios_Publicaciones_PublicacionID",
                        column: x => x.PublicacionID,
                        principalTable: "Publicaciones",
                        principalColumn: "PublicacionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_PublicacionID",
                table: "Comentarios",
                column: "PublicacionID");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_GrupoID",
                table: "Publicaciones",
                column: "GrupoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "Publicaciones");

            migrationBuilder.DropTable(
                name: "Grupos");
        }
    }
}
