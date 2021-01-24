using GameProjectDemo.Entity.Concrete;
using GameProjectDemo.Entity.Dtos;

namespace GameProjectDemo.Business.Abstract
{
    public interface IAuthService
    {
        void Register(UserForRegisterDto userForRegisterDto);
        User Login(UserForLoginDto userForLoginDto);
    }
}
