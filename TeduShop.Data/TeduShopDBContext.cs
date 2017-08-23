using System.Data.Entity;
using TeduShop.Model.Model;

namespace TeduShop.Data
{
    public partial class TeduShopDBContext : DbContext
    {
        public TeduShopDBContext() : base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnaabaled = false;
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategories> PostCategoriess { set; get; }

        public DbSet<PostTags> PostTagss { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductTags> ProductTagss { set; get; }

        public DbSet<ProductCategory> ProductCategorys { set; get; }
        public DbSet<Slides> Slidess { set; get; }
        public DbSet<SuportOnline> SuportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }

        public DbSet<Tags> Tagss { set; get; }
        public DbSet<Visitorstatistics> Visitorstatisticss { set; get; }
    }
}