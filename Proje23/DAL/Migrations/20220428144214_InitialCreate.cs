using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActivationCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    Text2 = table.Column<string>(type: "TEXT", nullable: true),
                    Question1 = table.Column<string>(type: "TEXT", nullable: true),
                    Question2 = table.Column<string>(type: "TEXT", nullable: true),
                    Question3 = table.Column<string>(type: "TEXT", nullable: true),
                    Question4 = table.Column<string>(type: "TEXT", nullable: true),
                    Question1Answers1 = table.Column<string>(type: "TEXT", nullable: true),
                    Question1Answers2 = table.Column<string>(type: "TEXT", nullable: true),
                    Question1Answers3 = table.Column<string>(type: "TEXT", nullable: true),
                    Question1Answers4 = table.Column<string>(type: "TEXT", nullable: true),
                    Question2Answers1 = table.Column<string>(type: "TEXT", nullable: true),
                    Question2Answers2 = table.Column<string>(type: "TEXT", nullable: true),
                    Question2Answers3 = table.Column<string>(type: "TEXT", nullable: true),
                    Question2Answers4 = table.Column<string>(type: "TEXT", nullable: true),
                    Question3Answers1 = table.Column<string>(type: "TEXT", nullable: true),
                    Question3Answers2 = table.Column<string>(type: "TEXT", nullable: true),
                    Question3Answers3 = table.Column<string>(type: "TEXT", nullable: true),
                    Question3Answers4 = table.Column<string>(type: "TEXT", nullable: true),
                    Question4Answers1 = table.Column<string>(type: "TEXT", nullable: true),
                    Question4Answers2 = table.Column<string>(type: "TEXT", nullable: true),
                    Question4Answers3 = table.Column<string>(type: "TEXT", nullable: true),
                    Question4Answers4 = table.Column<string>(type: "TEXT", nullable: true),
                    Q1Correct1 = table.Column<string>(type: "TEXT", nullable: true),
                    Q2Correct2 = table.Column<string>(type: "TEXT", nullable: true),
                    Q3Correct3 = table.Column<string>(type: "TEXT", nullable: true),
                    Q4Correct4 = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<string>(type: "TEXT", nullable: true),
                    UserModelId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_UserModels_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "UserModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UserModelId",
                table: "Exams",
                column: "UserModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "UserModels");
        }
    }
}
