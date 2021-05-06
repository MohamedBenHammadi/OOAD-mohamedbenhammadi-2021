using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEscapeGame
{
    abstract class Actor
    {
        public string Name { get; set; }
        public string Description { get; set; }


        public Actor(string name, string description)
        {
            Name = name;
            Description = description;

        }

        public override string ToString()
        {
            return Name;
        }

    }
}
