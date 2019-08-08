using Microsoft.EntityFrameworkCore.Migrations;

namespace HogwartsPotions.Migrations
{
    public partial class AddPotionTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Potions",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Potions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
