using System.Data.Entity;
namespace VirtualMuseum.Models
{
    public class ItemContext : DbContext
    {
        public ItemContext() : base("VirtualMuseum")
        {
        }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<ArtItem> ArtItems { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
