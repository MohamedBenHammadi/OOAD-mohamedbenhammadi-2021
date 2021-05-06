using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEscapeGame
{
    
    static class RandomMessageGenerator
    {

        static Random r = new Random();
        public enum MessageType { type1, type2, type3  };
        static string[] portable = { "That doesn't seem to work ", "", "It doesn't fit in my bag" };
        static string[] locked = { "The item isn't blocked ", "Try again", "That doesn't seem to work" };
        static string[] usable = { "The item isn't of any use ", "its not working", "please check youre item" };

        public static string GetRandomMessage(MessageType t) {

            string message = "";

            switch (t)
            {
                case MessageType.type1: message = portable[r.Next(0, portable.Length)];
                    break;
                case MessageType.type2: message = locked[r.Next(0, locked.Length)];
                    break;
                case MessageType.type3: message = usable[r.Next(0, usable.Length)];
                    break;    
            }

            return message;


        }
    }
}
