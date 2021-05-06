using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEscapeGame
{
    class Room : Actor
    {
     
       
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Door> Door { get; set; } = new List<Door>();
       
        public Room(string name, string desc) : base(name, desc)
        {
        
        }
    }
}
