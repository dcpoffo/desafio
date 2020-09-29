using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Placar = table.Column<int>(nullable: false),
                    PontuacaoMinimaTemporada = table.Column<int>(nullable: false),
                    PontuacaoMaximaTemporada = table.Column<int>(nullable: false),
                    QuantidadeRecordMinimoQuebrado = table.Column<int>(nullable: false),
                    QuantidadeRecordMaximoQuebrado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Jogo",
                columns: new[] { "Id", "Placar", "PontuacaoMaximaTemporada", "PontuacaoMinimaTemporada", "QuantidadeRecordMaximoQuebrado", "QuantidadeRecordMinimoQuebrado" },
                values: new object[] { 1, 12, 12, 12, 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogo");
        }
    }
}
