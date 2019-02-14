// Katheryn Weeden and Alyssa Hove
// Started: 2/1/19
// Program class: initiates interaction with user

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using static ConnectFour.Player;
using static ConnectFour.Board;



namespace ConnectFour
{
    class Program
    {
        //path to saved serialized data
        const string saveFileName = "Connect4Save.xml";
       
        static void Main(string[] args)
        {
            Game game = null;
 
            char input;
            //added to retrieve saved game
            if (File.Exists(saveFileName))
            {
                Console.Write("Do you want to resume an old game? (Y/N)");
                input = Console.ReadKey().KeyChar;
                File.Delete(saveFileName);
                if (input == 'y' || input == 'Y')
                {
                    Stream saveFile = File.OpenRead(saveFileName);
                    SoapFormatter deserializer = new SoapFormatter();
                    game = (Game)(deserializer.Deserialize(saveFile));
                    saveFile.Close();
                }
                //remove file regardless of restore or not since a new game would be started.
                File.Delete(saveFileName);
            }
            //game not restored so start a new one
            if (game == null)
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
                    Console.WriteLine("Player One choose your location, row then column, input save to save game"); // assumes input is correct "# #" 
                    x = Console.ReadLine();
                    if (String.Equals(x, "save", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Stream saveFile = File.Create(saveFileName);
                        SoapFormatter serializer = new SoapFormatter();
                        serializer.Serialize(saveFile, b);
                        saveFile.Close();
                        return;
                    }
                    VarRow = Convert.ToInt32(x.Split(' ')[0]);
                    VarCol = Convert.ToInt32(x.Split(' ')[1]);
                    placed = b.AddPiece(VarRow, VarCol, player, b);
                    while (placed == false)
                    {
                        Console.WriteLine("Player One invalid location choose another location, row then column");
                        x = Console.ReadLine();
                        if (String.Equals(x, "save", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Stream saveFile = File.Create(saveFileName);
                            SoapFormatter serializer = new SoapFormatter();
                            serializer.Serialize(saveFile, game);
                            saveFile.Close();
                            return;
                        }
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
                    Console.WriteLine("Player Two choose your location, row then column, input save to save game");
                    x = Console.ReadLine();
                   
                    if (String.Equals(x, "save", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Stream saveFile = File.Create(saveFileName);
                            SoapFormatter serializer = new SoapFormatter();
                            serializer.Serialize(saveFile, b);
                            saveFile.Close();
                            return;
                        }
                    
                    VarRow = Convert.ToInt32(x.Split(' ')[0]);
                    VarCol = Convert.ToInt32(x.Split(' ')[1]);
                    placed = b.AddPiece(VarRow, VarCol, playerTwo, b);
                    while (placed == false)
                    {
                        Console.WriteLine("Player Two invalid location choose another location, row then column");
                        x = Console.ReadLine();
                        if (String.Equals(x, "save", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Stream saveFile = File.Create(saveFileName);
                            SoapFormatter serializer = new SoapFormatter();
                            serializer.Serialize(saveFile, b);
                            saveFile.Close();
                            return;
                        }
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

        }

        }
    }


