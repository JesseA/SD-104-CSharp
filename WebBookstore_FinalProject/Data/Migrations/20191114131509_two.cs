using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FantasEBooks.Data.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LibraryID",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecommendationsRecID",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartCartID",
                table: "Book",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Library",
                columns: table => new
                {
                    LibraryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Library", x => x.LibraryID);
                });

            migrationBuilder.CreateTable(
                name: "Recommendations",
                columns: table => new
                {
                    RecID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendations", x => x.RecID);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    CartID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.CartID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_LibraryID",
                table: "Book",
                column: "LibraryID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_RecommendationsRecID",
                table: "Book",
                column: "RecommendationsRecID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_ShoppingCartCartID",
                table: "Book",
                column: "ShoppingCartCartID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Library_LibraryID",
                table: "Book",
                column: "LibraryID",
                principalTable: "Library",
                principalColumn: "LibraryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Recommendations_RecommendationsRecID",
                table: "Book",
                column: "RecommendationsRecID",
                principalTable: "Recommendations",
                principalColumn: "RecID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_ShoppingCart_ShoppingCartCartID",
                table: "Book",
                column: "ShoppingCartCartID",
                principalTable: "ShoppingCart",
                principalColumn: "CartID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Library_LibraryID",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Recommendations_RecommendationsRecID",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_ShoppingCart_ShoppingCartCartID",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Library");

            migrationBuilder.DropTable(
                name: "Recommendations");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_Book_LibraryID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_RecommendationsRecID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_ShoppingCartCartID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "LibraryID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "RecommendationsRecID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "ShoppingCartCartID",
                table: "Book");
        }
    }
}
