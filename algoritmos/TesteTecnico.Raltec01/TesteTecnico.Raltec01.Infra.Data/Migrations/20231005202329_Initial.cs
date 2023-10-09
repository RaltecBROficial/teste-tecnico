using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteTecnico.Raltec01.Infra.Data.Migrations
{
	/// <inheritdoc />
	public partial class Initial : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "products",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Name = table.Column<string>(type: "VARCHAR(100)", nullable: false),
					UnitValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_products", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "sales",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					CodeSale = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					DateAndHour = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_sales", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "sale_items",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					SaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
					Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_sale_items", x => x.Id);
					table.ForeignKey(
						name: "FK_sale_items_products_ProductId",
						column: x => x.ProductId,
						principalTable: "products",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_sale_items_sales_SaleId",
						column: x => x.SaleId,
						principalTable: "sales",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_sale_items_ProductId",
				table: "sale_items",
				column: "ProductId");

			migrationBuilder.CreateIndex(
				name: "IX_sale_items_SaleId",
				table: "sale_items",
				column: "SaleId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "sale_items");

			migrationBuilder.DropTable(
				name: "products");

			migrationBuilder.DropTable(
				name: "sales");
		}
	}
}
