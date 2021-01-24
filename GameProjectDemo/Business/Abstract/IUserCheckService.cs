using GameProjectDemo.Entity.Concrete;

namespace GameProjectDemo.Business.Abstract
{
    public interface IUserCheckService
    {
        bool CheckIfRealUser(User user);
    }
}
