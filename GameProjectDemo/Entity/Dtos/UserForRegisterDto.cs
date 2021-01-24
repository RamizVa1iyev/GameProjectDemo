using System;
using GameProjectDemo.Entity.Abstract;

namespace GameProjectDemo.Entity.Dtos
{
    public class UserForRegisterDto:IDto
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
