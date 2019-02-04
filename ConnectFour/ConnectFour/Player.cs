using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Player : Game
    {
        //public string color;
        public int turnNumber;
        public char piece; 

        public string PropPlayer
        {
            get
            {
                return piece;
                //return color;
            }

            set
            {
                piece = value;
                //color = value;
                
            }
        }
        
    }
}
