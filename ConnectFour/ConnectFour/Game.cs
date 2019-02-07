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
                Console.WriteLine("Player One chose your location, row then column");
                x = Console.ReadLine();
                VarRow = Convert.ToInt32(x.Split(' ')[0]);
                VarCol = Convert.ToInt32(x.Split(' ')[1]);
                b.AddPiece(VarRow, VarCol, player, b);
                b.DisplayBoard();

                Console.WriteLine("Player Two chose your location, row then column");
                x = Console.ReadLine();
                VarRow = Convert.ToInt32(x.Split(' ')[0]);
                VarCol = Convert.ToInt32(x.Split(' ')[1]);
                b.AddPiece(VarRow, VarCol, playerTwo, b);

            } while (win == false);
        }
        // Reset the current Game
        public void ResetGame()
        {

        }

    }
}