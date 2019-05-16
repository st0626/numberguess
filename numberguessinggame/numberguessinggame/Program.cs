using System;

namespace numberguessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            // start the game
            Console.WriteLine("Im thinking of a number between 1 and 10... can you guess what it is?");

            //allow the computer to pick a random number
            Random random = new Random();
            int randomNumber = random.Next(1, 10);


            //create a variable allowing the while loop to run
            bool playingGame = true;

            //start game after user input
            while (playingGame)
            {
                string userInput = Console.ReadLine();
                int parsedInput = int.Parse(userInput);

                // after user guesses, if it is wrong the game will continue to run
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
