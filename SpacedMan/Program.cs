using System;

namespace SpacedMan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game newGame = new Game();

            newGame.Greet();
            

            while (!newGame.DidWin() || !newGame.DidLose())
            {
                newGame.Display();

                newGame.Ask();
              
            }

            if (newGame.DidLose())
            {
                Console.WriteLine("Nice try");

            }
            else if (newGame.DidWin())
            {
                Console.WriteLine("Nice job");
            }

        }
    }
}
