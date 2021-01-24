using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entity.Abstract;

namespace GameProjectDemo.Entity.Concrete
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Percent { get; set; }
    }
}
