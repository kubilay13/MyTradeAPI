using MyTradeAPI.Data;
using MyTradeAPI.DTOs.UserDTOs;
using MyTradeAPI.Models.UserModel;

namespace MyTradeAPI.Services.UserService
{
    public class UserService
    {
        private readonly AppDbContext _appDbContext;

        public UserService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // Kullanıcı Listeleme
        public List<User> getAllUsers()
        {
            return _appDbContext.Users.ToList();
        }

        // Kullanıcı Oluşturma
        public User createUser(CreateUserDto createUserDto)
        {
            var user = new User
            {
                Username = createUserDto.UserName,
                UserEmail = createUserDto.UserEmail,
                Age = createUserDto.age,
                Password = createUserDto.Password,
                UserCreateTime = DateTime.UtcNow,

            };
            _appDbContext.Users.Add(user);
            _appDbContext.SaveChanges();
            return user;
        }

        // Kullanıcı Silme
        public bool deleteUser(int id)
        {
            var user = _appDbContext.Users.FirstOrDefault(x =>x.Id==id);

            if(user==null)
            {
                return false;
            }
            _appDbContext.Users.Remove(user);
            _appDbContext.SaveChanges();

            return true;
        }

        // Kullanıcı Güncelleme
        public User? updateUser(int id , CreateUserDto createUserDto)
        {
            var user = _appDbContext.Users.FirstOrDefault(x => x.Id==id);
            
            if(user == null)
            {
                return null;
            }

            user.Username=createUserDto.UserName;
            user.UserEmail=createUserDto.UserEmail;
            user.Age = createUserDto.age;
            _appDbContext.SaveChanges();
            return user;
        }
    }
}
