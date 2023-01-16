using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGCCheckIn.Migrations
{
    /// <inheritdoc />
    public partial class NewKeyGuardian : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Guardians",
                table: "Guardians");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Guardians",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "RecordID",
                table: "Guardians",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guardians",
                table: "Guardians",
                column: "RecordID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Guardians",
                table: "Guardians");

            migrationBuilder.DropColumn(
                name: "RecordID",
                table: "Guardians");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Guardians",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guardians",
                table: "Guardians",
                column: "PhoneNumber");
        }
    }
}
