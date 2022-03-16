//Nigel Little
//CITP 3310v03
//02/26/2022
//Lottery Program

using System;
using System.Linq;

/*Create a lottery game application. 
 * 
 * Generate four random numbers, each between 1 and 10. 
 * Allow the user to guess four numbers. 
 * Compare each of the user’s guesses to the four random numbers and display a message that includes: 
 *      the user’s guess, 
 *      the randomly determined four numbers, 
 *      and amount of money the user has won as follows:
 *          Any One matching: $10
 *          Two matching: $30
 *          Three matching: $100
 *          Four matching, not in order: $1000
 *          Four matching, in exact order: $10000
 *          No matches: $0
 *          
 * Make certain that your program accommodates repeating number. 
 * Save the file as Lottery.cs.
 *          
 *          Hint:
 *          Random RanNumber= new Random();
 *          Int ran1;
 *          ran1= RanNumber.Next(min,max)
*/

namespace Assignment3
{
    class Lottery
    {
        static void Main(string[] args)
        {
            //instantiate RNG
            Random rand = new Random();
            
            int[] randIntArray = new int[4];
            int[] guessArray = new int[4];
            int hits = 0; //to count the number of times guessed correctly

            //populate winning numbers in the array
            for (int i = randIntArray.GetLowerBound(0); i <= randIntArray.GetUpperBound(0); i++)
            {
                randIntArray[i] = rand.Next(1, 11); //upper bound is not inclusive
            }

            Console.WriteLine("Welcome to the lottery! \n\t4 random integer values between 1 and 10 will be generated.");
            Console.WriteLine("\tGuess the 4 values to win prizes!\n");

            //get user guesses
            for (int i = guessArray.GetLowerBound(0); i <= guessArray.GetUpperBound(0); i++)
            {
                Console.Write("\nPlease enter a guess for the lottery: ");
                guessArray[i] = int.Parse(Console.ReadLine());

                //check the value to see if it's between the range
                while (!BetweenRange(1, 10, guessArray[i]))
                {
                    Console.WriteLine("Value is not in range. Try again, 1 through 10.");
                    guessArray[i] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("\n");

            /*
             * Compare each of the user’s guesses to the four random numbers and display a message that includes: 
             *      the user’s guess, 
             *      the randomly determined four numbers, 
             *      and amount of money the user has won as follows:
             *          Any One matching: $10
             *          Two matching: $30
             *          Three matching: $100
             *          Four matching, not in order: $1000
             *          Four matching, in exact order: $10000
             *          No matches: $0
             */
            //compare
            for (int i = randIntArray.GetLowerBound(0); i <= randIntArray.GetUpperBound(0); i++)
            {
                for (int j = randIntArray.GetLowerBound(0); j <= randIntArray.GetUpperBound(0); j++)
                {
                    if (randIntArray[i] == guessArray[j])
                    {
                        //the logic here is that if the guess is found anywhere in the randomintegerarray
                        //then it's counted as one "hit" only, even if there are multiple instances
                        hits++;
                        break;
                    }
                }
            }

            //special comparison for edge condition where the two arrays are exactly the same
            if (randIntArray.SequenceEqual(guessArray))
            {
                hits = 5; //hits to 5 as a sentinel value
            }

            //display
            Console.WriteLine("\nCorrect values in the lottery were:");
            for (int i = randIntArray.GetLowerBound(0); i <= randIntArray.GetUpperBound(0); i++)
            {
                Console.Write("{0,4:N0} ", randIntArray[i]);
            }
            Console.Write("\n");

            Console.WriteLine("\nYour guesses were:");
            for (int i = guessArray.GetLowerBound(0); i <= guessArray.GetUpperBound(0); i++)
            {
                Console.Write("{0,4:N0} ", guessArray[i]);
            }
            Console.Write("\n");

            switch (hits)
            {
                case 0:
                    Console.WriteLine("You got {0} correct.", hits);
                    Console.WriteLine("You win $0 dollars. Sorry.");
                    break;

                case 1:
                    Console.WriteLine("You got {0} correct.", hits);
                    Console.WriteLine("You win $10 dollars. Not bad.");
                    break;

                case 2:
                    Console.WriteLine("You got {0} correct.", hits);
                    Console.WriteLine("You win $30 dollars. Nice.");
                    break;

                case 3:
                    Console.WriteLine("You got {0} correct.", hits);
                    Console.WriteLine("You win $100 dollars. Very nice.");
                    break;

                case 4:
                    Console.WriteLine("You got {0} correct but they're out of order.", hits);
                    Console.WriteLine("You win $1,000 dollars. Time to book a vacation.");
                    break;

                case 5:
                    Console.WriteLine("You got {0} correct and they're all in order!", (hits - 1));
                    Console.WriteLine("You're not cheating, are you?");
                    Console.WriteLine("You win $10,000 dollars. Don't quit your day job!");
                    break;
            }
        }

        public static bool BetweenRange(int lower, int upper, int checkValue)
        {
            return (lower <= checkValue && checkValue <= upper);
        }
    }
}