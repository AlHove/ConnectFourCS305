using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConnectFour.Game;


namespace ConnectFour
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Game g = new Game();
            int result;
            Console.WriteLine("Welcome to Connect Four. Would you like to start a new game or continue an old one? Press 0 for new" );
            if (int.TryParse(Console.ReadLine(), out result))
            {
                if (result == 0)
                {
                    g.NewGame();
                }
                if (result == 1)
                {
                    g.StartGame();
                }

            }

        }
    }
}


