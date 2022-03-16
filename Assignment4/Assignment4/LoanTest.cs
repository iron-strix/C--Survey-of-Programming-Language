//Nigel Little
//CITP 3310 v03
//Assignment 4
//03/01/22

/*
 * LoanTest class:
 * In the main class: 
 * instantiate an object of the loan class. --done
 * Allow the user to input data about the loan. --done with error checking for value types
 * Then use Loantable function to display the Loan information. --done
*/

using System;

namespace Assignment4
{
    class LoanTest
    {
        static void Main(string[] args)
        {
            //double Principle, double InterestRate, int Period
            // loan = new Loan(200000, 6, 15);
            Loan loan = new Loan();
            //loan.Principle = 200000;
            //loan.Period = 15;
            //loan.InterestRate = 6;

            //get principle, with error checking
            Console.Write("Please enter desired loan amount: ");
            var principleString = Console.ReadLine();
            
            double principle;
            bool doubleParse = double.TryParse(principleString, out principle);

            //do while guarantees one check at minimum on the value entered to see if double
            do
            {
                if (!doubleParse)
                {
                    Console.WriteLine("The value you entered was not a double, try again.");
                    Console.Write("Please enter desired loan amount:");
                    principleString = Console.ReadLine();
                    doubleParse = double.TryParse(principleString, out principle);
                }
            } while (!doubleParse);

            //store value in loan object after checking
            loan.Principle = principle;
            Console.WriteLine("Loan amount entered.");

            //get period, with error checking
            Console.Write("Please enter loan period in years: ");
            var periodString = Console.ReadLine();

            int period;
            bool intParse = int.TryParse(periodString, out period);

            //do while guarantees one check at minimum on the value entered to see if int
            do
            {
                if (!intParse)
                {
                    Console.WriteLine("The value you entered was not an integer, try again.");
                    Console.Write("Please enter loan period in years: ");
                    periodString = Console.ReadLine();
                    intParse = int.TryParse(periodString, out period);
                }
            } while (!intParse);

            //store value in loan object after checking
            loan.Period = period;
            Console.WriteLine("Period length entered.");

            //get principle, with error checking
            Console.Write("Please enter the APR: ");
            var interestString = Console.ReadLine();

            double interest;
            doubleParse = double.TryParse(interestString, out interest);

            //do while guarantees one check at minimum on the value entered to see if double
            do
            {
                if (!doubleParse)
                {
                    Console.WriteLine("The value you entered was not a double, try again.");
                    Console.Write("Please enter the APR: ");
                    interestString = Console.ReadLine();
                    doubleParse = double.TryParse(interestString, out interest);
                }
            } while (!doubleParse);

            //store value in loan object after checking
            loan.InterestRate = interest;
            Console.WriteLine("APR entered.");

            //wait for user
            Console.Write("\n\nPRESS ENTER TO DISPLAY LOAN TABLE");
            Console.Read();

            //Console.WriteLine("Monthly Payment: {0}\nInterest Paid: {1}", loan.MonthlyPayment().ToString("F"), loan.InterestPaid().ToString("F"));
            loan.LoanTable();
        }
    }
}
