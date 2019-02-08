//Katheryn Weeden and Alyssa Hove
//Started: 2/1/19
// Game class
//Deals with Starting the Game, Stopping the game, and restarting game
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConnectFour.Player;
using static ConnectFour.Board; 


namespace ConnectFour
{
    public class Game
    {
        // Start the game
        public void StartGame()
        {
          NewGame(); // method will also allow saved game in future 
        }
        // Start a New Game
        public void NewGame()
        {
            bool win = false;
            bool placed = false;
            string x;
            int VarCol;
            int VarRow;
            Board b = new Board();
            b.SetBoard();
            Player player = new Player();
            player.piece = 'X';
            Player playerTwo = new Player();
            playerTwo.piece = 'O';
            do
            {
                b.DisplayBoard();
                Console.WriteLine("Player One choose your location, row then column"); // assumes input is correct "# #" 
                x = Console.ReadLine();
                VarRow = Convert.ToInt32(x.Split(' ')[0]);
                VarCol = Convert.ToInt32(x.Split(' ')[1]);
                placed = b.AddPiece(VarRow, VarCol, player, b);
                while (placed == false)
                    {
                        Console.WriteLine("Player One invalid location choose another location, row then column");
                        x = Console.ReadLine();
                        VarRow = Convert.ToInt32(x.Split(' ')[0]);
                        VarCol = Convert.ToInt32(x.Split(' ')[1]);
                        placed = b.AddPiece(VarRow, VarCol, player, b);
                    }
                win = b.CheckWin(b, player);
                b.DisplayBoard();
                if (win == true)
                {
                    break;
                }
                Console.WriteLine("Player Two choose your location, row then column");
                x = Console.ReadLine();
                VarRow = Convert.ToInt32(x.Split(' ')[0]);
                VarCol = Convert.ToInt32(x.Split(' ')[1]);
                placed = b.AddPiece(VarRow, VarCol, playerTwo, b);
                while (placed == false)
                    {
                        Console.WriteLine("Player Two invalid location choose another location, row then column");
                        x = Console.ReadLine();
                        VarRow = Convert.ToInt32(x.Split(' ')[0]);
                        VarCol = Convert.ToInt32(x.Split(' ')[1]);
                        placed = b.AddPiece(VarRow, VarCol, playerTwo, b);
                    }
                win = b.CheckWin(b, playerTwo);
                if (win == true)
                {
                    b.DisplayBoard();
                }
            } while (win == false);
        }
        // Reset the current Game
        public void ResetGame()
        {

        }

    }
}