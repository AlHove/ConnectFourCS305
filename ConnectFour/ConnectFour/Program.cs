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
using static ConnectFour.Game;

namespace ConnectFour
{
    class Program
    {
        //path to saved serialized data
        const string saveFileName = "Connect4Save.xml"; 
        static void Main(string[] args)
        {
            Game g = new Game();
            int result;
            if (File.Exists(saveFileName))
            {
                Console.WriteLine("Welcome to Connect Four. Would you like to start a new game or continue an old one? Press 0 for new" );
                if (int.TryParse(Console.ReadLine(), out input))
                    if (input == 1)
                        {
                        Stream saveFile = File.OpenRead(saveFileName);
                        SoapFormatter deserializer = new SoapFormatter();
                        g = (Game)(deserializer.Deserialize(saveFile));
                        saveFile.Close();
                    }
                //remove file regardless of restore or not since a new game would be started.
                File.Delete(saveFileName);
            }
            //game not restored so start a new one
            if (g == null)
            {
                g.NewGame();
            }
            if (int.TryParse(Console.ReadLine(), out result))
            {
                if (result == 0)
                {
                    g.NewGame();
                    Console.WriteLine("Congratulations you won!");
                    Console.WriteLine("Press 1 for new Game. Press 2 to exit");
                    if (int.TryParse(Console.ReadLine(), out result))
                    {
                        if (result == 1)
                        {
                            g.NewGame();
                        }
                    }
                }
            }
        }
    }
}




