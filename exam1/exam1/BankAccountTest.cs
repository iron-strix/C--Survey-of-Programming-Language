/* Nigel Little
 * CITP 3310 - V03
 * 02/20/2022
 */

using System;


namespace exam1
{
    class BankAccountTest
    {
        static void Main(string[] args)
        {
            /*
             * “BankAccountTest” class: 
             *      instantiate two objects of the “BankAccount” class,
             *          1. checking and 
             *          2. saving accounts 
             *      and use the constructor to initialize the yearly interest rate for each account 
             *          (0.5% for checking account, 2.3% for saving account). 
             *      
             *      Allow the user to input his/her name and the balances for both accounts. 
             *      
             *      After the user inputs all the data, the program displays user’s name and initial balances for both accounts. 
             *      
             *      Then, the program calculates the balances with the interest after one year and updates 
             *      the balances for both accounts (objects) and displays the new balances for both accounts. 
             *      
             *      Repeat the step for two years of balance and display the new balance after two years for both accounts
             */

            //create the objects
            BankAccount checking = new BankAccount(0.5);
            BankAccount saving = new BankAccount(2.3);

            //need this placeholder variable to calculate interest
            //ideally CalculateInterest would be a member function of the object
            //but I'm sticking close to the prompt
            double interest;

            //prompt user
            Console.Out.WriteLine("Please input the first name to put on the checking account:");
            checking.FirstName = Console.In.ReadLine();
            Console.Out.WriteLine("Please input the last name to put on the checking account:");
            checking.LastName = Console.In.ReadLine();
            Console.Out.WriteLine("Please input an initial balance for the checking account:");
            checking.Balance = Double.Parse(Console.In.ReadLine());

            //prompt again
            Console.Out.WriteLine("Please input the first name to put on the savings account:");
            saving.FirstName = Console.In.ReadLine();
            Console.Out.WriteLine("Please input the last name to put on the savings account:");
            saving.LastName = Console.In.ReadLine();
            Console.Out.WriteLine("Please input an initial balance for the savings account:");
            saving.Balance = Double.Parse(Console.In.ReadLine());

            //display output
            Console.Out.WriteLine("=========================================================");
            Console.Out.WriteLine("{0} {1} Checking Account Balance: ${2}", checking.FirstName, checking.LastName, checking.Balance.ToString("F"));
            Console.Out.WriteLine("{0} {1} Savings Account Balance: ${2}", saving.FirstName, saving.LastName, saving.Balance.ToString("F"));

            //crunch 1 year of interest for accounts
            // formula is I = Prt where I is interest, P is principal, r is rate as a decimal, and t is time period
            Console.Out.WriteLine("\nCalculating 1 year of interest on the accounts...");
            interest = checking.Balance * (checking.YearlyInterest / 100);
            checking.Balance = checking.Balance + interest;

            interest = saving.Balance * (saving.YearlyInterest / 100);
            saving.Balance = saving.Balance + interest;

            //display new amounts
            Console.Out.WriteLine("=========================================================");
            Console.Out.WriteLine("{0} {1} Checking Account Balance: ${2}", checking.FirstName, checking.LastName, checking.Balance.ToString("F"));
            Console.Out.WriteLine("{0} {1} Savings Account Balance: ${2}", saving.FirstName, saving.LastName, saving.Balance.ToString("F"));

            //crunch 2 years of interest for accounts
            Console.Out.WriteLine("\nCalculating 2 years of interest on the accounts...");
            for(int i = 0; i < 2; i++)
            {
                interest = checking.Balance * (checking.YearlyInterest / 100);
                checking.Balance = checking.Balance + interest;

                interest = saving.Balance * (saving.YearlyInterest / 100);
                saving.Balance = saving.Balance + interest;
            }

            //display again
            Console.Out.WriteLine("=========================================================");
            Console.Out.WriteLine("{0} {1} Checking Account Balance: ${2}", checking.FirstName, checking.LastName, checking.Balance.ToString("F"));
            Console.Out.WriteLine("{0} {1} Savings Account Balance: ${2}", saving.FirstName, saving.LastName, saving.Balance.ToString("F"));
        }
    }
}
