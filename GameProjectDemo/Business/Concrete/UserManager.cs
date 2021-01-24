using System;
using GameProjectDemo.Business.Abstract;
using GameProjectDemo.Entity.Concrete;

namespace GameProjectDemo.Business.Concrete
{
    public class UserManager:IUserService
    {
        public void Add(User user)
        {
            Console.WriteLine($"{user.FirsName} added to DB!");
        }

        public void Update(User user)
        {
            Console.WriteLine($"{user.FirsName} updated!");
        }

        public void Delete(User user)
        {
            Console.WriteLine($"{user.FirsName} deleted!");
        }

        public User GetUserByEMail(string email)
        {
            return new User(){FirsName = "Ramiz",TcNo = "1234567890"};
        }
    }
}
