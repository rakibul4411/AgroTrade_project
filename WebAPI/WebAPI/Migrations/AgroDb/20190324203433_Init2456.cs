using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations.AgroDb
{
    public partial class Init2456 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Farmer_List",
                columns: table => new
                {
                    Farmer_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Farmer_Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmer_List", x => x.Farmer_ID);
                });

            migrationBuilder.CreateTable(
                name: "Local_Traders_Details",
                columns: table => new
                {
                    Local_Trader_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Local_Trader_Name = table.Column<string>(nullable: true),
                    Local_Buying_Price = table.Column<decimal>(nullable: false),
                    Transportation_Cost = table.Column<decimal>(nullable: false),
                    Storing_Cost = table.Column<decimal>(nullable: false),
                    Total_Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local_Traders_Details", x => x.Local_Trader_ID);
                });

            migrationBuilder.CreateTable(
                name: "Market_List",
                columns: table => new
                {
                    Market_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Market_Name = table.Column<string>(nullable: true),
                    Market_Address = table.Column<string>(nullable: true),
                    Post_Code = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Country_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Market_List", x => x.Market_ID);
                });

            migrationBuilder.CreateTable(
                name: "Product_Category",
                columns: table => new
                {
                    Product_Category_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_Category_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Category", x => x.Product_Category_ID);
                });

            migrationBuilder.CreateTable(
                name: "Product_Unit",
                columns: table => new
                {
                    Product_Unit_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_Unit_Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Unit", x => x.Product_Unit_ID);
                });

            migrationBuilder.CreateTable(
                name: "Retailers_Details",
                columns: table => new
                {
                    Retailer_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Retailer_Name = table.Column<string>(nullable: true),
                    Retailers_Buying_Price = table.Column<decimal>(nullable: false),
                    Transportation_Cost = table.Column<decimal>(nullable: false),
                    Total_Cost_PerUnit = table.Column<decimal>(nullable: false),
                    Retailer_Selling_Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retailers_Details", x => x.Retailer_ID);
                });

            migrationBuilder.CreateTable(
                name: "Trader_Category",
                columns: table => new
                {
                    Trader_Category_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Trader_Category_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trader_Category", x => x.Trader_Category_ID);
                });

            migrationBuilder.CreateTable(
                name: "Whole_Salers",
                columns: table => new
                {
                    Whole_Saler_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Whole_Saler_Name = table.Column<string>(nullable: true),
                    Whole_Saler_Buying_Cost = table.Column<decimal>(nullable: false),
                    Whole_Saler_Transportation_Cost = table.Column<decimal>(nullable: false),
                    Whole_Saler_Storing_Cost = table.Column<decimal>(nullable: false),
                    Whole_Saler_Total_Cost = table.Column<decimal>(nullable: false),
                    Whole_Saler_Selling_Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whole_Salers", x => x.Whole_Saler_ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_Name = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    Product_Source = table.Column<string>(nullable: true),
                    Product_Category_ID = table.Column<int>(nullable: true),
                    Market_ID = table.Column<int>(nullable: false),
                    Product_Unit_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_ID);
                    table.ForeignKey(
                        name: "FK_Products_Market_List_Market_ID",
                        column: x => x.Market_ID,
                        principalTable: "Market_List",
                        principalColumn: "Market_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Product_Category_Product_Category_ID",
                        column: x => x.Product_Category_ID,
                        principalTable: "Product_Category",
                        principalColumn: "Product_Category_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Product_Unit_Product_Unit_ID",
                        column: x => x.Product_Unit_ID,
                        principalTable: "Product_Unit",
                        principalColumn: "Product_Unit_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Traders_List",
                columns: table => new
                {
                    Trader_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Trader_Name = table.Column<string>(nullable: true),
                    Trader_Address = table.Column<string>(nullable: true),
                    Trader_Category_ID = table.Column<int>(nullable: true),
                    Market_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traders_List", x => x.Trader_ID);
                    table.ForeignKey(
                        name: "FK_Traders_List_Market_List_Market_ID",
                        column: x => x.Market_ID,
                        principalTable: "Market_List",
                        principalColumn: "Market_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Traders_List_Trader_Category_Trader_Category_ID",
                        column: x => x.Trader_Category_ID,
                        principalTable: "Trader_Category",
                        principalColumn: "Trader_Category_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Imported_Product_Source",
                columns: table => new
                {
                    Imported_Product_Source_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Imported_Product_Buying_Cost = table.Column<decimal>(nullable: false),
                    Shipment_Cost = table.Column<decimal>(nullable: false),
                    Custom_Tax = table.Column<decimal>(nullable: false),
                    Transportation_Cost = table.Column<decimal>(nullable: false),
                    Storing_Cost = table.Column<decimal>(nullable: false),
                    Total_Cost = table.Column<decimal>(nullable: false),
                    Importers_WholeSale_Price = table.Column<decimal>(nullable: false),
                    Product_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imported_Product_Source", x => x.Imported_Product_Source_ID);
                    table.ForeignKey(
                        name: "FK_Imported_Product_Source_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Local_Product_Source",
                columns: table => new
                {
                    Local_Product_Source_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Seeding_Cost = table.Column<decimal>(nullable: false),
                    Ploughing_Cost = table.Column<decimal>(nullable: false),
                    Watering_Cost = table.Column<decimal>(nullable: false),
                    Labour_Cost = table.Column<decimal>(nullable: false),
                    Processing_Cost = table.Column<decimal>(nullable: false),
                    Total_Production_Cost = table.Column<decimal>(nullable: false),
                    Product_ID = table.Column<int>(nullable: false),
                    Farmer_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local_Product_Source", x => x.Local_Product_Source_ID);
                    table.ForeignKey(
                        name: "FK_Local_Product_Source_Farmer_List_Farmer_ID",
                        column: x => x.Farmer_ID,
                        principalTable: "Farmer_List",
                        principalColumn: "Farmer_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Local_Product_Source_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Local_Trader_Order_Details",
                columns: table => new
                {
                    Local_Trader_Order_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Local_Trader_ID = table.Column<int>(nullable: false),
                    Product_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local_Trader_Order_Details", x => x.Local_Trader_Order_ID);
                    table.ForeignKey(
                        name: "FK_Local_Trader_Order_Details_Local_Traders_Details_Local_Trader_ID",
                        column: x => x.Local_Trader_ID,
                        principalTable: "Local_Traders_Details",
                        principalColumn: "Local_Trader_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Local_Trader_Order_Details_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Retailers_Order_Details",
                columns: table => new
                {
                    Retailer_Order_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Retailer_ID = table.Column<int>(nullable: false),
                    Product_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retailers_Order_Details", x => x.Retailer_Order_ID);
                    table.ForeignKey(
                        name: "FK_Retailers_Order_Details_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Retailers_Order_Details_Retailers_Details_Retailer_ID",
                        column: x => x.Retailer_ID,
                        principalTable: "Retailers_Details",
                        principalColumn: "Retailer_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Whole_Saler_Order_Details",
                columns: table => new
                {
                    Order_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Whole_Saler_ID = table.Column<int>(nullable: true),
                    Product_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whole_Saler_Order_Details", x => x.Order_ID);
                    table.ForeignKey(
                        name: "FK_Whole_Saler_Order_Details_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Whole_Saler_Order_Details_Whole_Salers_Whole_Saler_ID",
                        column: x => x.Whole_Saler_ID,
                        principalTable: "Whole_Salers",
                        principalColumn: "Whole_Saler_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imported_Product_Source_Product_ID",
                table: "Imported_Product_Source",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Local_Product_Source_Farmer_ID",
                table: "Local_Product_Source",
                column: "Farmer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Local_Product_Source_Product_ID",
                table: "Local_Product_Source",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Local_Trader_Order_Details_Local_Trader_ID",
                table: "Local_Trader_Order_Details",
                column: "Local_Trader_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Local_Trader_Order_Details_Product_ID",
                table: "Local_Trader_Order_Details",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Market_ID",
                table: "Products",
                column: "Market_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Product_Category_ID",
                table: "Products",
                column: "Product_Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Product_Unit_ID",
                table: "Products",
                column: "Product_Unit_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Retailers_Order_Details_Product_ID",
                table: "Retailers_Order_Details",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Retailers_Order_Details_Retailer_ID",
                table: "Retailers_Order_Details",
                column: "Retailer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Traders_List_Market_ID",
                table: "Traders_List",
                column: "Market_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Traders_List_Trader_Category_ID",
                table: "Traders_List",
                column: "Trader_Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Whole_Saler_Order_Details_Product_ID",
                table: "Whole_Saler_Order_Details",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Whole_Saler_Order_Details_Whole_Saler_ID",
                table: "Whole_Saler_Order_Details",
                column: "Whole_Saler_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imported_Product_Source");

            migrationBuilder.DropTable(
                name: "Local_Product_Source");

            migrationBuilder.DropTable(
                name: "Local_Trader_Order_Details");

            migrationBuilder.DropTable(
                name: "Retailers_Order_Details");

            migrationBuilder.DropTable(
                name: "Traders_List");

            migrationBuilder.DropTable(
                name: "Whole_Saler_Order_Details");

            migrationBuilder.DropTable(
                name: "Farmer_List");

            migrationBuilder.DropTable(
                name: "Local_Traders_Details");

            migrationBuilder.DropTable(
                name: "Retailers_Details");

            migrationBuilder.DropTable(
                name: "Trader_Category");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Whole_Salers");

            migrationBuilder.DropTable(
                name: "Market_List");

            migrationBuilder.DropTable(
                name: "Product_Category");

            migrationBuilder.DropTable(
                name: "Product_Unit");
        }
    }
}
