using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleCategories_ArticleCategories_ParentId",
                table: "ArticleCategories");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "ArticleCategories",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleCategories_ArticleCategories_ParentId",
                table: "ArticleCategories",
                column: "ParentId",
                principalTable: "ArticleCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleCategories_ArticleCategories_ParentId",
                table: "ArticleCategories");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "ArticleCategories",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleCategories_ArticleCategories_ParentId",
                table: "ArticleCategories",
                column: "ParentId",
                principalTable: "ArticleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
