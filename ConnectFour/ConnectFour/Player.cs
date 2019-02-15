//Alyssa Hove and Katheryn Weeden
// Started 2/1/19
//Player class: Keeps track of Player Data

namespace ConnectFour
{
    public class Player
    {
        public int turnNumber;
        public char piece; // Player Symbol X or O

        public char PropPlayer
        {
            get
            {
                return piece;
            }

            set
            {
                piece = value;
                turnNumber = value;
            }
        }

        public int getTurnNumber()
        {
            return turnNumber;
        }
    }
}
