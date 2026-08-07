using Microsoft.EntityFrameworkCore;
using MyTradeAPI.Models.Enums;
using MyTradeAPI.Models.ProductModel;
using MyTradeAPI.Models.UserModel;

namespace MyTradeAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // =========================
            // USERS
            // =========================

            modelBuilder.Entity<User>().HasData(

                new User
                {
                    Id = 1,
                    Username = "ahmet",
                    UserEmail = "ahmet@test.com",
                    Password = "1234",
                    Age = 27,
                    UserCreateTime = new DateTime(2026, 8, 1)
                },

                new User
                {
                    Id = 2,
                    Username = "mehmet",
                    UserEmail = "mehmet@test.com",
                    Password = "1234",
                    Age = 31,
                    UserCreateTime = new DateTime(2026, 8, 2)
                },

                new User
                {
                    Id = 3,
                    Username = "ayse",
                    UserEmail = "ayse@test.com",
                    Password = "1234",
                    Age = 24,
                    UserCreateTime = new DateTime(2026, 8, 3)
                }
            );


            // =========================
            // PRODUCTS
            // =========================

            modelBuilder.Entity<Product>().HasData(

                // Ahmet'in sattığı cihaz
                new Product
                {
                    Id = 1,
                    UserId = 1,

                    ProductTitle = "iPhone 15 Pro 256GB",

                    ProductDescription =
                        "Telefon temiz kullanılmıştır. Herhangi bir sorunu bulunmamaktadır.",

                    ProductFeatures =
                        "256GB, A17 Pro, 8GB RAM, %92 pil sağlığı",

                    // Kullanıcının senden istediği fiyat
                    ExpectedPrice = 40000,

                    // Senin verdiğin teklif
                    OfferPrice = 35000,

                    // Henüz mağazaya girmedi
                    ProductPrice = null,

                    Status = ProductStatus.OfferSent,

                    Stock = 0,

                    CreatedAt = new DateTime(2026, 8, 4)
                },


                // Mehmet'in sattığı cihaz
                new Product
                {
                    Id = 2,
                    UserId = 2,

                    ProductTitle = "PlayStation 5 Slim",

                    ProductDescription =
                        "PS5 Slim temiz kullanılmıştır. Kutu ve faturası bulunmaktadır.",

                    ProductFeatures =
                        "1TB SSD, 4K, DualSense",

                    ExpectedPrice = 22000,

                    // Henüz teklif vermedin
                    OfferPrice = null,

                    ProductPrice = null,

                    Status = ProductStatus.Pending,

                    Stock = 0,

                    CreatedAt = new DateTime(2026, 8, 5)
                },


                // Ayşe'nin sattığı cihaz
                new Product
                {
                    Id = 3,
                    UserId = 3,

                    ProductTitle = "MacBook Air M2",

                    ProductDescription =
                        "MacBook Air M2 çok temiz durumdadır.",

                    ProductFeatures =
                        "M2, 8GB RAM, 256GB SSD",

                    ExpectedPrice = 30000,

                    // Sen teklif verdin
                    OfferPrice = 27000,

                    ProductPrice = null,

                    Status = ProductStatus.Accepted,

                    Stock = 0,

                    CreatedAt = new DateTime(2026, 8, 6)
                },


                // Satın aldığın ve mağazaya koyduğun ürün
                new Product
                {
                    Id = 4,
                    UserId = 1,

                    ProductTitle = "Samsung Galaxy S24 Ultra",

                    ProductDescription =
                        "Temiz kullanılmış Samsung Galaxy S24 Ultra.",

                    ProductFeatures =
                        "256GB, 12GB RAM, Snapdragon 8 Gen 3",

                    ExpectedPrice = 35000,

                    OfferPrice = 32000,

                    // Artık senin satış fiyatın
                    ProductPrice = 39999,

                    Status = ProductStatus.InStore,

                    Stock = 1,

                    CreatedAt = new DateTime(2026, 8, 7)
                }
            );


            // =========================
            // PRODUCT IMAGES
            // =========================

            modelBuilder.Entity<ProductImage>().HasData(

                // iPhone 15 Pro
                new ProductImage
                {
                    Id = 1,
                    ProductId = 1,
                    ImageUrl = "https://example.com/iphone15pro-1.jpg"
                },

                new ProductImage
                {
                    Id = 2,
                    ProductId = 1,
                    ImageUrl = "https://example.com/iphone15pro-2.jpg"
                },

                // PS5
                new ProductImage
                {
                    Id = 3,
                    ProductId = 2,
                    ImageUrl = "https://example.com/ps5-1.jpg"
                },

                new ProductImage
                {
                    Id = 4,
                    ProductId = 2,
                    ImageUrl = "https://example.com/ps5-2.jpg"
                },

                // MacBook
                new ProductImage
                {
                    Id = 5,
                    ProductId = 3,
                    ImageUrl = "https://example.com/macbook-m2-1.jpg"
                },

                // Samsung
                new ProductImage
                {
                    Id = 6,
                    ProductId = 4,
                    ImageUrl = "https://example.com/s24ultra-1.jpg"
                },

                new ProductImage
                {
                    Id = 7,
                    ProductId = 4,
                    ImageUrl = "https://example.com/s24ultra-2.jpg"
                }
            );
        }
    }
}
