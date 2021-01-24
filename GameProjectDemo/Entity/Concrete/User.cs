using System;
using GameProjectDemo.Entity.Abstract;

namespace GameProjectDemo.Entity.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
