using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectX.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMasterTemplateAndMasterTemplateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateTypeId = table.Column<int>(type: "int", nullable: false),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MasterTemplates_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    TimeStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateTimes_MasterTemplates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "MasterTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemplateTimes_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterTemplates_MasterId",
                table: "MasterTemplates",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateTimes_MasterId",
                table: "TemplateTimes",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateTimes_TemplateId",
                table: "TemplateTimes",
                column: "TemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemplateTimes");

            migrationBuilder.DropTable(
                name: "MasterTemplates");
        }
    }
}
