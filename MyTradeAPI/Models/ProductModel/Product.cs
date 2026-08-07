using MyTradeAPI.Models.Enums;
using MyTradeAPI.Models.UserModel;

namespace MyTradeAPI.Models.ProductModel
{
    public class Product
    {
        public int Id { get; set; }

        // Ürünü sisteme gönderen kullanıcı
        public int UserId { get; set; }
        public User User { get; set; }

        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public string ProductFeatures { get; set; }

        // Kullanıcının senden istediği fiyat
        public decimal ExpectedPrice { get; set; }

        // Senin kullanıcıya verdiğin teklif
        public decimal? OfferPrice { get; set; }

        // Senin mağazada satış fiyatın
        public decimal? ProductPrice { get; set; }

        public ProductStatus Status { get; set; }

        public int Stock { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<ProductImage> Images { get; set; }
            = new List<ProductImage>();
    }
}
