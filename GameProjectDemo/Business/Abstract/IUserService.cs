using GameProjectDemo.Entity.Concrete;

namespace GameProjectDemo.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        User GetUserByEMail(string email);
    }
}
