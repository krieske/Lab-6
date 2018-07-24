using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));

        static void Main(string[] args)
        {
            // while loop to play the game again
            // user input to pick # of sides for dice
             

            // user input to roll the dice
            int result1, result2;
            string rollAgain = "yes";
            string continuePlay = "y";

            while (continuePlay == "y")
            {
                Console.WriteLine("Welcome to the Grand Circus Casino!");
                Console.WriteLine("Fancy a game of dice? (y/n)");
                rollAgain = ValidatePlayAgain(); // ToDo: add validation for the user choice
                if (rollAgain != "y")
                {
                    return;
                }
                Console.WriteLine("Choose the sides of die (6, 8, or 10)");
                int sides = GetNumberWithinRange();
                Console.WriteLine($"Awesome, you picked {sides}!");
                result1 = RandNumber(sides, "Roll 1: "); // sides is the max/highest number from user input
                result2 = RandNumber(sides, "Roll 2: ");
                RollTypes(result1, result2);
                // ToDo: print the result of Box cars, snake eyes, .....


                Console.WriteLine("Do you want to play another game?");
                continuePlay = Console.ReadLine();
            }
            Console.WriteLine("Thanks for playing! Goodbye!");
                
        }

        public static string ValidateSides()
        {
            string input = Console.ReadLine();

            while (input==null || !Regex.IsMatch(input, @"^\d{1,2}$") )
            {
                Console.WriteLine("Please enter a valid number.");
                input = Console.ReadLine();
            }
            return input; 
        } // finished

        public static int GetNumberWithinRange()
        {
            int min = 6;
            int max = 10;
            int num = int.Parse(ValidateSides());

            while ((num > max || num < min || num %2 == 1))
            {
                Console.WriteLine("Please pick either 6, 8 or 10.");
                num = int.Parse(ValidateSides());
            }
            return num;
        } // finished


        public static int RandNumber(int Sides, string message)
        {

            int rnd = rndNum.Next(1, Sides);

            Console.WriteLine(message + rnd);

            return rnd;
        } // finished

        public static string ValidatePlayAgain()
        {
            string rollAgain = Console.ReadLine();

            while (true) //rollAgain == null || ((rollAgain != "yes") || (rollAgain != "y") || (rollAgain != "Yes") || (rollAgain != "YES")))
            {
                if (rollAgain == "y")
                {
                    return rollAgain;
                }
                Console.WriteLine("Thanks for playing! Goodbye!");
                return rollAgain;
            }
            //return rollAgain;
        } // finished


        public static void RollTypes(int n1, int n2)
        {
            if (n1 == 1 && n2 == 1)
            {
                Console.WriteLine("You rolled snake eyes!");
            }
            else if ((n1 == 1 && n2 == 2) || (n1 == 2 && n2 == 1))
            {
                Console.WriteLine("You rolled an ace deuce!");
            }
            else if ((n1 == 1 && n2 == 3) || (n1 == 3 && n2 == 1))
            {
                Console.WriteLine("You rolled an easy four!");
            }
            else if ((n1 == 1 && n2 == 4) || (n1 == 4 && n2 == 1))
            {
                Console.WriteLine("You rolled a fever five!");
            }
            else if ((n1 == 1 && n2 == 5) || (n1 == 5 && n2 == 1))
            {
                Console.WriteLine("You rolled an easy six!");
            }
            else if ((n1 == 1 && n2 == 6) || (n1 == 6 && n2 == 1))
            {
                Console.WriteLine("You rolled a seven out!");
            }
            else if (n1 == 2 && n2 == 2)
            {
                Console.WriteLine("You rolled a hard four!");
            }
            else if ((n1 == 2 && n2 == 3) || (n1 == 3 && n2 == 2))
            {
                Console.WriteLine("You rolled a fever five!");
            }
            else if ((n1 == 4 && n2 == 2) || (n1 == 2 && n2 == 4))
            {
                Console.WriteLine("You rolled an easy six!");
            }
            else if ((n1 == 5 && n2 == 2) || (n1 == 2 && n2 == 5))
            {
                Console.WriteLine("You rolled a seven out!");
            }
            else if ((n1 == 6 && n2 == 2) || (n1 == 2 && n2 == 6))
            {
                Console.WriteLine("You rolled an easy eight!");
            }
            else if (n1 == 3 && n2 == 3)
            {
                Console.WriteLine("You rolled a hard six!");
            }
            else if ((n1 == 3 && n2 == 4) || (n1 == 4 && n2 == 3))
            {
                Console.WriteLine("You rolled a seven out!");
            }
            else if ((n1 == 5 && n2 == 3) || (n1 == 3 && n2 == 5))
            {
                Console.WriteLine("You rolled an easy eight!");
            }
            else if ((n1 == 6 && n2 == 3) || (n1 == 3 && n2 == 6))
            {
                Console.WriteLine("You rolled a Nina!");
            }
            else if (n1 == 4 && n2 == 4)
            {
                Console.WriteLine("You rolled a hard eight!");
            }
            else if ((n1 == 4 && n2 == 5) || (n1 == 5 && n2 == 4))
            {
                Console.WriteLine("You rolled a Nina!");
            }
            else if ((n1 == 4 && n2 == 6) || (n1 == 6 && n2 == 4))
            {
                Console.WriteLine("You rolled an easy ten!");
            }
            else if (n1 == 5 && n2 == 5)
            {
                Console.WriteLine("You rolled an easy ten!");
            }
            else if ((n1 == 5 && n2 == 6) || (n1 == 6 && n2 == 5))
            {
                Console.WriteLine("You rolled a yo-leven!");
            }
            else if(n1 == 6 && n2 == 6)
            {
                Console.WriteLine("You rolled a boxcar!");
            }
        }

    }
}
