using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacedMan
{
    public class Game
    {
        public string Codeword { get; set; }

        public string CurrentWord { get; set; }
        public int maxNumOfGuesses { get; set; }

        public int currentNumOfWrongGuesses { get; set; }

        public string[] codeWordOptions = new string[] {  "quick", "paint", "table", "waist", "panic", "sloth" };

        Ufo UFO = new Ufo();

        public Game()
        {


            //Set codeword to random values in array of word options
            var rng = new Random();

            

            Codeword = codeWordOptions[rng.Next(codeWordOptions.Length)];

            //Set max num of guesses to five
            maxNumOfGuesses = 5;

            //set num of wrong guess to zero

            currentNumOfWrongGuesses = 0;
            CurrentWord = "";
            foreach (char c in Codeword)
            {
                CurrentWord += '_';
            }



        }
        public bool Ask()
        {
            Console.WriteLine("Guess a letter");
            for (int i = 0; i <= 5; i++)
            {
                string c = Console.ReadLine();
                if (c.Length > 1)
                {
                    Console.WriteLine("One letter at a time");
                    return false;
                }
                if (Codeword.Contains(c))
                {
                    int index = Codeword.IndexOf(c);
                    CurrentWord = CurrentWord.Remove(index, 1).Insert(index, $"{c}");
                    Console.WriteLine($"Current Word: {CurrentWord}"); 
                   
                }
                else if (!Codeword.Contains(c))
                {
                    Console.WriteLine("Increase Number of Wrong Guesses by 1");
                    UFO.AddPart();
                    Console.WriteLine(UFO.Stringify());
                    currentNumOfWrongGuesses++; 
                }
                if (currentNumOfWrongGuesses > 5)
                {
                    return false;
                }

            }
            return false;
            
        }
        public void Display()
        {
            Console.WriteLine(UFO.Stringify());
            Console.WriteLine(CurrentWord);
            Console.Write("Number of guesses:");
            Console.WriteLine(maxNumOfGuesses - currentNumOfWrongGuesses);
        }
        public bool DidLose()
        {
            if (currentNumOfWrongGuesses >= maxNumOfGuesses)
            {
                return true;
            }
            return false;

        }
        public bool DidWin()
        {
            if (CurrentWord.Equals(Codeword))
            {
                return true;
            }
            return false;

        }
        public void Greet()
        {
            Console.WriteLine("==========");
            Console.WriteLine("UFO: The Game:");
            Console.WriteLine("==========");

            Console.WriteLine("Instructions: Save your friend from the aliens by guessing the correct word");

        }
    }
}
    

