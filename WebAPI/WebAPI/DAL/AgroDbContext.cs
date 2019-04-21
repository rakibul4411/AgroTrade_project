using Microsoft.EntityFrameworkCore;
using WebAPI.Models_Table;

namespace WebAPI.DAL
{
    public class AgroDbContext:DbContext
    {
        public AgroDbContext(DbContextOptions<AgroDbContext> options) : base(options) { }




        public DbSet<Trader_Category> Trader_Category { get; set; }

        public DbSet<Traders_List> Traders_List { get; set; }

        public DbSet<Market_List> Market_List { get; set; }
        public DbSet<Product_Category> Product_Category { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Product_Unit> Product_Unit { get; set; }
        public DbSet<Farmer_List> Farmer_List { get; set; }
        public DbSet<Local_Product_Source> Local_Product_Source { get; set; }
        public DbSet<Local_Traders_Details> Local_Traders_Details { get; set; }
        public DbSet<Imported_Product_Source> Imported_Product_Source { get; set; }
        public DbSet<Whole_Salers> Whole_Salers { get; set; }
        public DbSet<Retailers_Details> Retailers_Details { get; set; }
        public DbSet<Local_Trader_Order_Details> Local_Trader_Order_Details { get; set; }
        public DbSet<Whole_Saler_Order_Details> Whole_Saler_Order_Details { get; set; }
        public DbSet<Retailers_Order_Details> Retailers_Order_Details { get; set; }
    }
}
