using GameProjectDemo.Entity.Abstract;

namespace GameProjectDemo.Entity.Dtos
{
    public class UserForLoginDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
