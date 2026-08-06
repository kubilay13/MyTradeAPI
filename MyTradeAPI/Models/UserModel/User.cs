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
        public int TheProductsItSells { get; set; }
        public int PurchasedProducts { get; set; }
    }
}
