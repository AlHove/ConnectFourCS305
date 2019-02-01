using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Player : Game
    {
        public string color;
        public int turnNumber;

        public string PropPlayer
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
        
    }
}
