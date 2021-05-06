using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEscapeGame
{
    class Item: LockalableItem
    {
    
        public bool IsPortable { get; set; } = true;
       
       
       

        public Item(string name, string description) : base(name, description)
        {

         
        }
        public Item(string name, string description, bool portable) : base (name, description)
        {
           
            IsPortable = portable;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
