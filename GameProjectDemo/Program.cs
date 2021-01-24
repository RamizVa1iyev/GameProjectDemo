using System;
using GameProjectDemo.Business.Abstract;
using GameProjectDemo.Business.Adapters;
using GameProjectDemo.Business.Concrete;
using GameProjectDemo.Entity.Concrete;
using GameProjectDemo.Entity.Dtos;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IAuthService authService = new AuthManager(new UserManager(), new CheckPersonServiceAdapter());
            IGameService gameService = new GameManager(new CampaignManager());


            var userForRegister = new UserForRegisterDto()
            {
                FirstName = "Ramiz", TcNo = "1234567890", BirthDay = new DateTime(2002, 11, 8), LastName = "Valiyev",
                Email = "example@gmail.com", Password = "12345"
            };
            var userForLogin = new UserForLoginDto(){Password = "12345",Email = "example@gmail.com"};
            var game = new Game(){Name = "GTA 5",Price = 50};
            var campaign = new Campaign(){Name = "Black Friday campaign",Percent = 0.20M};



            authService.Register(userForRegister);
            var user = authService.Login(userForLogin);

            gameService.BuyGame(game,user,campaign);

        }
    }
}
