using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3_Num_Guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int findMe, guess, track;
            string feedback, again;
            bool tryAgain = true;
            
            do
            {
                Random genNum = new Random();
                findMe = genNum.Next(1, 100);
                track = 0;
                Console.WriteLine("Welcome to the number guessing game. \nI'm thinking of an integer between 1 and 100. \nWhat do you think it is...?");
                while(tryAgain)
                {
                    string x = Console.ReadLine();
                    while (!(int.TryParse(x, out guess)))
                    {
                        Console.WriteLine("Sigh... that wasn't even an integer. Try again");
                        x = Console.ReadLine();
                    }
                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Didn't I say it was between 1 and 100? /n...try again");
                        x = Console.ReadLine();
                    }
                    track++;
                    tryAgain = Feedback(guess, findMe);
                }
                
                
                //Console.WriteLine("You guessed {0}." );
                Console.WriteLine("Thats right, I was thinking of {0}.", findMe);
                Console.WriteLine("Do you want to play again? y/n");
                again = Console.ReadLine();
                again = again.ToLower();
            } while (again == "y");

            Console.ReadLine();
        }
        public static bool Feedback(int x, int findMe)
        {
            int j = x - findMe;
            if (j >= 25 || j <= -25)
            {
                Console.WriteLine("...why do you make me play with you? That wasn't even close");
                Console.WriteLine("Guess again...");
                return true;
            }
            else if (j >= 10)
            {
                Console.WriteLine("That was way too high.");
                Console.WriteLine("Guess again...");
                return true;
            }
            else if (j <= -10)
            {
                Console.WriteLine("That was way too low.");
                Console.WriteLine("Guess again...");
                return true;
            }
            else if (x > findMe)
            {
                Console.WriteLine("Too high.");
                Console.WriteLine("Guess again...");
                return true;
            }
            else if (x < findMe)
            {
                Console.WriteLine("Too low.");
                Console.WriteLine("Guess again...");
                return true;
            }
            else
            {
                return false;
            }
            
        
        }

    }
}
