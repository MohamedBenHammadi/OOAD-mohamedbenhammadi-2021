using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEscapeGame
{
    class LockalableItem : Actor
    {

        public bool IsLocked { get; set; } = false;
        public Item Key { get; }
        public Item HiddenItem { get; set; }
        public LockalableItem(string name, string desc) : base (name, desc) { }
    }
}
