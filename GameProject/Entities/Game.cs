using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string NameOfGame { get; set; }
        public decimal PriceOfGame { get; set; }
    }
}
