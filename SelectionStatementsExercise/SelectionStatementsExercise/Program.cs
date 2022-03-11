using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
            Console.WriteLine("What is your favorite school subject");
            string subj = Console.ReadLine();
            switch (subj)
            {
                case "English":
                    Console.WriteLine($"{subj}, you must love to read!");
                    break;
                case "Spanish":
                    Console.WriteLine($"{subj}, esta muy bien");
                    break;
                case "Math":
                    Console.WriteLine($"{subj}, something doesn't add up");
                    break;
                case "History":
                    Console.WriteLine($"{subj}, you may have a problem letting things go");
                    break;
                case "Geography":
                    Console.WriteLine($"{subj}, another thing you and Michael Jordan have in common");
                    break;
            }
        }
    }
}