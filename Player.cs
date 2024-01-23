using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public class Player
    {
        public string Name { get; set; }
        public EJokenpo Move { get; set; }

        public Player(string name, EJokenpo move) { 
            Name = name;
            Move = move;
        }
    }
}
