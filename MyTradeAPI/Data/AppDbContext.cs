using Microsoft.EntityFrameworkCore;
using MyTradeAPI.Models.UserModel;

namespace MyTradeAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "kubilay", UserEmail="akdogankubilay431@gmail.com" , Password = "1234", Age=20 , PurchasedProducts=3 , TheProductsItSells=3 , UserCreateTime=DateTime.Now }
            );
        }
    }
}
