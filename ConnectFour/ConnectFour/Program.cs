// Katheryn Weeden and Alyssa Hove
// Started: 2/1/19
// Program class: initiates interaction with user

using System;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace ConnectFour
{
    class Program
    {
        //path to saved serialized data
        const string saveFileName = "Connect4Save.xml";
        const string newGameFile = "Connect4Start.xml";

        static void Main(string[] args)
        {
            Game game = new Game();
            string result = "";

            char input;
            //added to retrieve saved game
            if (File.Exists(saveFileName))
            {
                Console.Write("Do you want to resume an old game? (Y/N) ");
                input = Console.ReadKey().KeyChar;
                if (input == 'y' || input == 'Y')
                {
                    Stream saveFile = File.OpenRead(saveFileName);
                    SoapFormatter deserializer = new SoapFormatter();
                    int turn = (int)(deserializer.Deserialize(saveFile));
                    char[,] g = (char[,])(deserializer.Deserialize(saveFile));
                    saveFile.Close();
                    Console.WriteLine();
                    result = game.StartGame(g, turn);

                    // Once the game is won, delete the saved file
                    if (result == "w")
                    {
                        File.Delete(saveFileName);
                    }
                }
                else
                {
                    Console.WriteLine("\nHere is a new game instead:");
                    Stream newGame = File.OpenRead(newGameFile);
                    SoapFormatter deserializer = new SoapFormatter();
                    int turn = (int)(deserializer.Deserialize(newGame));
                    char[,] g = (char[,])(deserializer.Deserialize(newGame));
                    newGame.Close();
                    Console.WriteLine();
                    result = game.StartGame(g, turn);
                }
            }
            else
            {
                Console.WriteLine("Welcome to Connect Four");
                Stream newGame = File.OpenRead(newGameFile);
                SoapFormatter deserializer = new SoapFormatter();
                int turn = (int)(deserializer.Deserialize(newGame));
                char[,] g = (char[,])(deserializer.Deserialize(newGame));
                newGame.Close();
                Console.WriteLine();
                result = game.StartGame(g, turn);
            }

            if (result == "w")
            {
                Console.WriteLine("Congratulations! You won! Enter any key to exit");
                Console.ReadKey();
            }
            else if (result == "s")
            {
                Console.WriteLine("Your game has been saved. Enter any key to exit");
                Console.ReadKey();
            }
        }
    }
}
