using eshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Services
{
    public class UserService : IUserService
    {
        private List<User> users = new()
        {
             new(){ Id=1, UserName="turkay", FullName="Türkay Ürkmez", Email="turkay@abc.com", Password="123456", Role="Admin"},
             new(){ Id=1, UserName="buse", FullName="Buse Doğan", Email="buse@abc.com", Password="123456", Role="Editor"},
             new(){ Id=1, UserName="mert", FullName="Mert Erdem", Email="mert@abc.com", Password="123456", Role="Client"},

        };

        public User ValidateUser(string userName, string password)
        {
            return users.SingleOrDefault(u => u.UserName == userName && u.Password == password);
        }
    }
}
