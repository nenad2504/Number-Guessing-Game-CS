using System;

namespace Number_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;
            int minVal = 1;
            int maxVal = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(minVal, maxVal + 1);
                // Console.WriteLine("Number is " + number);
                response = "";

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + minVal + " - " + maxVal + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }

                    guesses++;
                }

                Console.WriteLine("Number " + number);
                Console.WriteLine("You win!");
                Console.WriteLine("Guesses " + guesses);

                Console.WriteLine("Would you like to play again (Y/N)?");
                response = Console.ReadLine();
                string resp = response.ToUpper();

                if (resp == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
            
            Console.ReadKey();
        }
    }
}