﻿// Katheryn Weeden and Alyssa Hove
// Started: 2/1/19
// Game class: Deals with Starting the Game, Stopping the game, and restarting game

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConnectFour.Player;
using static ConnectFour.Board;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace ConnectFour
{
    public class Game
    {
        // Start the game
        // Method will also allow saved game in future
        // Returns a "w" for win or a "s" for save
        public string StartGame(char[,] g)
        {
            Board b = new Board();
            b.SetExistingBoard(g);
            return (PlayGame(b));
        }

        // Start a New Game
        // Returns a "w" for win or a "s" for save
        public string NewGame()
        {
            //Initialize the board
            Board b = new Board();
            b.SetBoard();
            return(PlayGame(b));
        }

        // Continues to prompt users to play until a win or save occurs
        // Returns a "w" for win or a "s" for save
        public string PlayGame(Board b)
        {
            bool win = false;
            bool placed = false;
            string x;
            int VarCol;
            int VarRow;
            
            //Initialize the players
            Player player = new Player();
            player.piece = 'X';
            Player playerTwo = new Player();
            playerTwo.piece = 'O';

            //Loops through a series of asking player one and two to input a location
            //Assumes the location input is always formatted as 'row# col#' w/o error checking
            do
            {
                b.DisplayBoard();
                Console.WriteLine("Player One choose your location, row then column, or input save to save game");
                x = SaveGame(Console.ReadLine(), b);
                if (x == "save")
                {
                    return "s";
                }
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

                Console.WriteLine("Player Two choose your location, row then column, or input save to save game");
                x = SaveGame(Console.ReadLine(), b);
                if (x == "save")
                {
                    return "s";
                }
                VarRow = Convert.ToInt32(x.Split(' ')[0]);
                VarCol = Convert.ToInt32(x.Split(' ')[1]);
                placed = b.AddPiece(VarRow, VarCol, playerTwo, b);

                while (placed == false)
                {
                    Console.WriteLine("Player Two invalid location choose another location");
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
            return "w";
        }

        // Checks user input for save and saves the current game if requested
        public string SaveGame(string s, Board b)
        {
            if (String.Equals(s, "save", StringComparison.CurrentCultureIgnoreCase))
            {
                Stream saveFile = File.Create("Connect4Save.xml");
                SoapFormatter serializer = new SoapFormatter();
                serializer.Serialize(saveFile, b.GetBoard());
                saveFile.Close();
                return "save";
            }
            return s;
        }

        /* Will later implement this feature
        
        // Reset the current Game by creating a new one
        public void ResetGame()
        {
            NewGame();
        }

        */
    }
}