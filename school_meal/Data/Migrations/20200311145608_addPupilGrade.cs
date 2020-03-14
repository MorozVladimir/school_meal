using Microsoft.EntityFrameworkCore.Migrations;

namespace school_meal.Data.Migrations
{
    public partial class addPupilGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "pupilGrade",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pupilGrade",
                table: "AspNetUsers");
        }
    }
}
