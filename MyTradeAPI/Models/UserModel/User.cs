using MyTradeAPI.Models.ProductModel;

namespace MyTradeAPI.Models.UserModel
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string UserEmail { get; set; }
        public int Age { get; set; }
        public DateTime UserCreateTime { get; set; }
        public string Password { get; set; }
        public ICollection<Product> Products { get; set; }
            = new List<Product>();
    }
}
