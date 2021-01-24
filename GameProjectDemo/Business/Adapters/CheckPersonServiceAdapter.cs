using GameProjectDemo.Business.Abstract;
using GameProjectDemo.Business.Services;
using GameProjectDemo.Entity.Concrete;

namespace GameProjectDemo.Business.Adapters
{
    public class CheckPersonServiceAdapter:IUserCheckService
    {
        public bool CheckIfRealUser(User user)
        {
            var checkPersonService = new CheckPersonService();
            return checkPersonService.CheckPerson(user.TcNo, user.BirthDay, user.FirsName, user.LastName);
        }
    }
}
