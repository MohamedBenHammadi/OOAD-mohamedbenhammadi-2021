using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEscapeGame
{
    class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPortable { get; set; } = true;
        public bool IsLocked { get; set; } = false;
        public Item Key { get; set; }
        public Item HiddenItem { get; set; }

        public Item(string name, string desc)
        {
            Name = name;
            Description = desc;
        }
        public Item(string name, string desc, bool portable)
        {
            Name = name;
            Description = desc;
            IsPortable = portable;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
