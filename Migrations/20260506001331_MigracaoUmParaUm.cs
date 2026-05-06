using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_Arma",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_Arma",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_Arma",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_Arma",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_Arma",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_Arma",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_Arma",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_Arma",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 111, 180, 208, 197, 124, 249, 187, 156, 214, 90, 68, 60, 16, 33, 136, 1, 160, 143, 82, 58, 79, 104, 165, 121, 185, 216, 43, 177, 26, 199, 78, 41, 64, 221, 42, 15, 210, 183, 45, 80, 251, 171, 82, 241, 103, 82, 246, 98, 25, 39, 162, 133, 166, 57, 101, 1, 215, 112, 115, 209, 189, 63, 240, 12 }, new byte[] { 33, 140, 225, 165, 119, 131, 226, 147, 216, 168, 108, 35, 223, 193, 192, 180, 7, 188, 217, 153, 131, 205, 53, 102, 186, 191, 129, 187, 161, 67, 237, 197, 44, 71, 112, 35, 37, 166, 230, 117, 213, 254, 132, 96, 69, 222, 199, 101, 253, 180, 85, 255, 240, 168, 172, 53, 46, 172, 184, 153, 85, 162, 244, 165, 226, 114, 73, 103, 61, 76, 177, 72, 33, 46, 121, 67, 29, 141, 53, 79, 56, 176, 249, 243, 201, 227, 68, 145, 5, 233, 99, 243, 97, 63, 78, 22, 16, 22, 242, 41, 243, 190, 119, 138, 174, 210, 105, 25, 199, 77, 11, 40, 186, 35, 86, 138, 54, 117, 168, 166, 216, 179, 139, 127, 57, 72, 117, 89 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Arma_PersonagemId",
                table: "TB_Arma",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Arma_TB_PERSONAGENS_PersonagemId",
                table: "TB_Arma",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_Arma_TB_PERSONAGENS_PersonagemId",
                table: "TB_Arma");

            migrationBuilder.DropIndex(
                name: "IX_TB_Arma_PersonagemId",
                table: "TB_Arma");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_Arma");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 24, 244, 103, 129, 163, 123, 102, 92, 247, 127, 150, 3, 0, 84, 113, 96, 245, 176, 24, 160, 187, 112, 245, 197, 68, 163, 109, 52, 153, 117, 95, 40, 115, 138, 56, 5, 65, 128, 163, 251, 132, 246, 37, 38, 90, 165, 219, 185, 153, 240, 138, 101, 51, 177, 10, 149, 37, 94, 112, 176, 156, 111, 61, 192 }, new byte[] { 234, 150, 162, 212, 95, 5, 125, 219, 221, 100, 143, 222, 190, 2, 88, 206, 85, 66, 239, 145, 0, 148, 98, 241, 177, 112, 217, 248, 245, 149, 35, 23, 114, 211, 184, 207, 218, 144, 59, 206, 43, 20, 212, 89, 6, 242, 108, 53, 73, 178, 48, 233, 249, 221, 124, 95, 145, 44, 52, 19, 157, 146, 187, 218, 159, 60, 190, 161, 236, 6, 26, 148, 239, 238, 117, 49, 120, 55, 226, 50, 114, 90, 114, 216, 12, 176, 58, 118, 243, 24, 39, 12, 164, 62, 230, 208, 104, 137, 236, 110, 233, 230, 118, 100, 2, 175, 238, 101, 245, 52, 203, 142, 208, 28, 94, 229, 169, 2, 38, 108, 236, 159, 190, 8, 119, 181, 88, 35 } });
        }
    }
}
