using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEscapeGame
{
    class Door: Actor
    {


        public Item HiddenItem { get; set; }
        public Item Key { get; set; }

        public bool IsLocked { get; set; } = false;
        public Room ToRoom { get; set; }


        public Door(string name, string desc) : base(name, desc)
        {
         
        }

        public override string ToString()
        {
            return Name;
        }



    }
}
