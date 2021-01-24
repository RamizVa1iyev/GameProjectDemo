using System;
using GameProjectDemo.Business.Abstract;
using GameProjectDemo.Entity.Concrete;
using GameProjectDemo.Entity.Dtos;

namespace GameProjectDemo.Business.Concrete
{
    public class AuthManager:IAuthService
    {
        private readonly IUserService _userManager;
        private readonly IUserCheckService _userCheckService;
        public AuthManager(IUserService userManager, IUserCheckService userCheckService)
        {
            _userManager = userManager;
            _userCheckService = userCheckService;
        }

        public void Register(UserForRegisterDto userForRegisterDto)
        {
            _userManager.Add(new User()
            {
                FirsName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                BirthDay = userForRegisterDto.BirthDay,
                Email = userForRegisterDto.Email,
                Password = userForRegisterDto.Password,
                TcNo = userForRegisterDto.TcNo
            });
            Console.WriteLine($"{userForRegisterDto.FirstName} registered!");
        }

        public User Login(UserForLoginDto userForLoginDto)
        {
            var user = _userManager.GetUserByEMail(userForLoginDto.Email);
            if (!_userCheckService.CheckIfRealUser(user))
            {
                throw new Exception("The Person is not exist");
            }
            Console.WriteLine($"{user.FirsName} logged in!");
            return user;
        }
    } 
}
