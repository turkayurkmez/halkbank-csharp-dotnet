using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eshop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class create_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Elektronik" },
                    { 2, "Tekstil" },
                    { 3, "Kırtasiye" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "Apple", "https://cdn.dsmcdn.com/ty1005/product/media/images/prod/PIM/20230929/05/970e9a76-4ce0-4aed-81ce-7b4b8123736a/1_org_zoom.jpg", "Akıllı Saat", 4000m, 150 },
                    { 2, 1, "Android", "https://cdn.dsmcdn.com/ty1005/product/media/images/prod/PIM/20230929/05/970e9a76-4ce0-4aed-81ce-7b4b8123736a/1_org_zoom.jpg", "Samsung A51", 3500m, 120 },
                    { 3, 2, "LCW", "https://cdn.dsmcdn.com/ty1005/product/media/images/prod/PIM/20230929/05/970e9a76-4ce0-4aed-81ce-7b4b8123736a/1_org_zoom.jpg", "Tişört", 4000m, 150 },
                    { 4, 3, "Defterler", "https://cdn.dsmcdn.com/ty1005/product/media/images/prod/PIM/20230929/05/970e9a76-4ce0-4aed-81ce-7b4b8123736a/1_org_zoom.jpg", "Defter seti", 400m, 150 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
