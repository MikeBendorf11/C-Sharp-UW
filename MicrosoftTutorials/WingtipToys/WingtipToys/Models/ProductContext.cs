//entity framework 
using System.Data.Entity;

namespace WingtipToys.Models
{
    //Access the db
    public class ProductContext : DbContext
    {
        //context.- access to underlying data
        public ProductContext() : base("WingtipToys")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails{ get; set; }
    }
}

