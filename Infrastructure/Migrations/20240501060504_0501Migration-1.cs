using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _0501Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryVariations_ProductCategory_ProductCategoryId",
                table: "CategoryVariations");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryVariations_VariationValue_VariationValueId",
                table: "CategoryVariations");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Addresses_AddressId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipper_Addresses_AddressId",
                table: "Shipper");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItem_ShoppingCart_ShoppingCartId",
                table: "ShoppingCartItem");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "ProductVariation");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItem_ShoppingCartId",
                table: "ShoppingCartItem");

            migrationBuilder.DropIndex(
                name: "IX_Shipper_AddressId",
                table: "Shipper");

            migrationBuilder.DropIndex(
                name: "IX_Customer_AddressId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_CategoryVariations_ProductCategoryId",
                table: "CategoryVariations");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ShoppingCartItem");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Shipper");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductVariationValue");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "CategoryVariations");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "VariationValue",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "ShoppingCartItem",
                newName: "Qty");

            migrationBuilder.RenameColumn(
                name: "ShoppingCartId",
                table: "ShoppingCartItem",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Shipper",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customer",
                newName: "Profile_PIC");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customer",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "VariationValueId",
                table: "CategoryVariations",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryVariations_VariationValueId",
                table: "CategoryVariations",
                newName: "IX_CategoryVariations_CategoryId");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Addresses",
                newName: "Street2");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Addresses",
                newName: "Street1");

            migrationBuilder.AddColumn<int>(
                name: "CategoryVariationId",
                table: "VariationValue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VariationId",
                table: "VariationValue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "ShoppingCartItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson",
                table: "Shipper",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmailId",
                table: "Shipper",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Promotion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductVariationValue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VariationValueId",
                table: "ProductVariationValue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductImage",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Qty",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VariationName",
                table: "CategoryVariations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PromotionDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromotionId = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PromotionDetail_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PromotionDetail_Promotion_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RatingValue = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    isDefaultAddress = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAddress_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserAddress_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShipperRegion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    ShipperId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipperRegion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipperRegion_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShipperRegion_Shipper_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Shipper",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VariationValue_CategoryVariationId",
                table: "VariationValue",
                column: "CategoryVariationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationValue_ProductId",
                table: "ProductVariationValue",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationValue_VariationValueId",
                table: "ProductVariationValue",
                column: "VariationValueId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionDetail_ProductCategoryId",
                table: "PromotionDetail",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionDetail_PromotionId",
                table: "PromotionDetail",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_ProductId",
                table: "Review",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipperRegion_RegionId",
                table: "ShipperRegion",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipperRegion_ShipperId",
                table: "ShipperRegion",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_AddressId",
                table: "UserAddress",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_CustomerId",
                table: "UserAddress",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryVariations_ProductCategory_CategoryId",
                table: "CategoryVariations",
                column: "CategoryId",
                principalTable: "ProductCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariationValue_Product_ProductId",
                table: "ProductVariationValue",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariationValue_VariationValue_VariationValueId",
                table: "ProductVariationValue",
                column: "VariationValueId",
                principalTable: "VariationValue",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VariationValue_CategoryVariations_CategoryVariationId",
                table: "VariationValue",
                column: "CategoryVariationId",
                principalTable: "CategoryVariations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryVariations_ProductCategory_CategoryId",
                table: "CategoryVariations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariationValue_Product_ProductId",
                table: "ProductVariationValue");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariationValue_VariationValue_VariationValueId",
                table: "ProductVariationValue");

            migrationBuilder.DropForeignKey(
                name: "FK_VariationValue_CategoryVariations_CategoryVariationId",
                table: "VariationValue");

            migrationBuilder.DropTable(
                name: "PromotionDetail");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "ShipperRegion");

            migrationBuilder.DropTable(
                name: "UserAddress");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropIndex(
                name: "IX_VariationValue_CategoryVariationId",
                table: "VariationValue");

            migrationBuilder.DropIndex(
                name: "IX_ProductVariationValue_ProductId",
                table: "ProductVariationValue");

            migrationBuilder.DropIndex(
                name: "IX_ProductVariationValue_VariationValueId",
                table: "ProductVariationValue");

            migrationBuilder.DropColumn(
                name: "CategoryVariationId",
                table: "VariationValue");

            migrationBuilder.DropColumn(
                name: "VariationId",
                table: "VariationValue");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "ShoppingCartItem");

            migrationBuilder.DropColumn(
                name: "ContactPerson",
                table: "Shipper");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Shipper");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Promotion");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Promotion");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Promotion");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductVariationValue");

            migrationBuilder.DropColumn(
                name: "VariationValueId",
                table: "ProductVariationValue");

            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Qty",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "SKU",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "VariationName",
                table: "CategoryVariations");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "VariationValue",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Qty",
                table: "ShoppingCartItem",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "ShoppingCartItem",
                newName: "ShoppingCartId");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Shipper",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Profile_PIC",
                table: "Customer",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Customer",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "CategoryVariations",
                newName: "VariationValueId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryVariations_CategoryId",
                table: "CategoryVariations",
                newName: "IX_CategoryVariations_VariationValueId");

            migrationBuilder.RenameColumn(
                name: "Street2",
                table: "Addresses",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Street1",
                table: "Addresses",
                newName: "Street");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ShoppingCartItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Shipper",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductVariationValue",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId",
                table: "CategoryVariations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillingAddressId = table.Column<int>(type: "int", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Addresses_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductVariation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductVariationValueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariation_ProductVariationValue_ProductVariationValueId",
                        column: x => x.ProductVariationValueId,
                        principalTable: "ProductVariationValue",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductVariation_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    ShipperId = table.Column<int>(type: "int", nullable: false),
                    ShippingAddressId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Addresses_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_Shipper_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Shipper",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItem_ShoppingCartId",
                table: "ShoppingCartItem",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipper_AddressId",
                table: "Shipper",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AddressId",
                table: "Customer",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryVariations_ProductCategoryId",
                table: "CategoryVariations",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentId",
                table: "Order",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShipperId",
                table: "Order",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShippingAddressId",
                table: "Order",
                column: "ShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_BillingAddressId",
                table: "Payment",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariation_ProductId",
                table: "ProductVariation",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariation_ProductVariationValueId",
                table: "ProductVariation",
                column: "ProductVariationValueId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_CustomerId",
                table: "ShoppingCart",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryVariations_ProductCategory_ProductCategoryId",
                table: "CategoryVariations",
                column: "ProductCategoryId",
                principalTable: "ProductCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryVariations_VariationValue_VariationValueId",
                table: "CategoryVariations",
                column: "VariationValueId",
                principalTable: "VariationValue",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Addresses_AddressId",
                table: "Customer",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipper_Addresses_AddressId",
                table: "Shipper",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItem_ShoppingCart_ShoppingCartId",
                table: "ShoppingCartItem",
                column: "ShoppingCartId",
                principalTable: "ShoppingCart",
                principalColumn: "Id");
        }
    }
}
