using GameProjectDemo.Entity.Abstract;

namespace GameProjectDemo.Entity.Concrete
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
