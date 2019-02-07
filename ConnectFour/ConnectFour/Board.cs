//Katheryn Weeden and Alyssa Hove
//Started: 2/1/19
// Board class: deals with validating spaces and checking for wins and losses
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConnectFour.Player;

namespace ConnectFour
{
    public class Board
    {
        // Instance Variables 
        public int row;
        public int col;
        public bool win;
        char[,] Grid = new char[7, 7];


        public Board()
        {
            SetBoard();
        }

        // Setter
        public void SetBoard()
        {
            Grid = new char[7, 7];
        }

        // Getter
         public Array GetBoard()
           {
            return this.Grid;
           }

        // methods
        public bool ValidateLocation(Board b, int row, int col) // validate that location is free
        {
            if (b.Grid[row, col] == 'X' ||
                b.Grid[row,col] == 'O' )
            {
                return false;
            }
            if (b.Grid[row, col] == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

     /*   public bool CheckWin(Board b, Player p) { // all encompassing win check
            bool win = false;
            char token = p.piece;
            for (int i = 0; i < 7; i++)
            {

                for (int ix = 0; ix < 7; i++)
                {
                    //Diagonal win /
                    if (b.Grid[i, ix] == token &&
                        b.Grid[i - 1, ix - 1] == token &&
                        b.Grid[i - 2, ix - 2] == token &&
                        b.Grid[i - 3, ix - 3] == token)
                    {
                        win = true;
                        return win;
                    }
                    // Horizontal win	-
                    if (b.Grid[i, ix] == token &&
                        b.Grid[i - 1, ix] == token &&
                        b.Grid[i - 2, ix] == token &&
                        b.Grid[i - 3, ix] == token)
                    {
                        win = true;
                        return win;
                    }
                    //Diagonal win \
                    if (b.Grid[i, ix] == token &&
                    b.Grid[i - 1, ix + 1] == token &&
                    b.Grid[i - 2, ix + 2] == token &&
                    b.Grid[i - 3, ix + 3] == token)
                    {
                        win = true;
                        return win;
                    }
                    // Vertical win |
                    if (b.Grid[i, ix] == token &&
                         b.Grid[i, ix + 1] == token &&
                         b.Grid[i, ix + 2] == token &&
                         b.Grid[i, ix + 3] == token)
                    {
                        win = true;
                        return win;
                    }
                    else
                    {
                         win = false;
                        return win;
                    }
                }
                
            }
            return win;
        }
        */
        public void DisplayBoard() { //show current board
            Console.WriteLine("  1 2 3 4 5 6 7 ");
            for (int i = 0; i < 7; i++)
            { Console.Write(i + 1);
                for (int j = 0; j < 7; j++)
                {
                    Console.Write('|');
                    Console.Write(this.Grid[i, j]);
                }
                Console.WriteLine('|');
                Console.WriteLine(" ______________");
            }
        }
        public void AddPiece(int row,int col,Player p, Board b){
            row = row - 1;
            col = col - 1;
            ValidateLocation(b, row, col);
            b.Grid[row, col] = p.piece;
           // CheckWin(b,p);

        }
    }
}
