//Alyssa Hove and Katheryn Weeden
// Started 2/1/19
//Player class: Keeps track of Player Data
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
        public int turnNumber; //track of turn
        public char piece; // Player Symbol

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
