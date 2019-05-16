using System;

namespace numberguessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Im thinking of a number between 1 and 10... can you guess what it is?");

            Random random = new Random();
            int randomNumber = random.Next(1, 10);

            bool playingGame = true;

            while (playingGame)
            {
                string userInput = Console.ReadLine();
                int parsedInput = int.Parse(userInput);


                if (parsedInput != randomNumber)
                {
                    Console.WriteLine("Sorry try again!");
                }
                else
                {
                    Console.WriteLine("You win! you guessed the number");
                    playingGame = false;
                }
            }
            
        }
    }
}
