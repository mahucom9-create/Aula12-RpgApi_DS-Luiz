using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 36, 82, 25, 1, 169, 4, 104, 72, 1, 137, 57, 246, 9, 101, 116, 30, 117, 66, 36, 38, 161, 84, 93, 84, 245, 240, 58, 251, 231, 196, 183, 9, 60, 188, 157, 132, 173, 78, 234, 151, 52, 172, 77, 182, 212, 5, 56, 131, 36, 31, 154, 173, 210, 232, 127, 47, 7, 164, 96, 94, 223, 51, 122, 117 }, new byte[] { 199, 8, 236, 38, 227, 237, 14, 151, 62, 96, 120, 42, 204, 216, 115, 147, 40, 187, 124, 36, 156, 107, 205, 15, 58, 130, 75, 174, 115, 106, 191, 245, 157, 31, 174, 166, 126, 47, 32, 219, 99, 14, 242, 106, 51, 223, 43, 144, 253, 204, 244, 47, 7, 132, 141, 209, 58, 45, 218, 59, 239, 250, 123, 66, 127, 121, 41, 213, 45, 23, 88, 160, 124, 24, 226, 150, 111, 31, 252, 213, 25, 241, 65, 26, 184, 2, 48, 246, 208, 79, 108, 0, 60, 20, 249, 13, 235, 150, 4, 58, 153, 143, 142, 27, 39, 111, 83, 177, 19, 35, 146, 88, 21, 121, 39, 211, 175, 202, 19, 18, 208, 73, 178, 209, 157, 203, 7, 190 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 111, 180, 208, 197, 124, 249, 187, 156, 214, 90, 68, 60, 16, 33, 136, 1, 160, 143, 82, 58, 79, 104, 165, 121, 185, 216, 43, 177, 26, 199, 78, 41, 64, 221, 42, 15, 210, 183, 45, 80, 251, 171, 82, 241, 103, 82, 246, 98, 25, 39, 162, 133, 166, 57, 101, 1, 215, 112, 115, 209, 189, 63, 240, 12 }, new byte[] { 33, 140, 225, 165, 119, 131, 226, 147, 216, 168, 108, 35, 223, 193, 192, 180, 7, 188, 217, 153, 131, 205, 53, 102, 186, 191, 129, 187, 161, 67, 237, 197, 44, 71, 112, 35, 37, 166, 230, 117, 213, 254, 132, 96, 69, 222, 199, 101, 253, 180, 85, 255, 240, 168, 172, 53, 46, 172, 184, 153, 85, 162, 244, 165, 226, 114, 73, 103, 61, 76, 177, 72, 33, 46, 121, 67, 29, 141, 53, 79, 56, 176, 249, 243, 201, 227, 68, 145, 5, 233, 99, 243, 97, 63, 78, 22, 16, 22, 242, 41, 243, 190, 119, 138, 174, 210, 105, 25, 199, 77, 11, 40, 186, 35, 86, 138, 54, 117, 168, 166, 216, 179, 139, 127, 57, 72, 117, 89 } });
        }
    }
}
