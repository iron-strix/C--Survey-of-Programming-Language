/* Nigel Little
 * CITP 3310 - V03
 * 02/20/2022
 */

using System;

namespace exam1
{
    class BankAccount
    {
        /*
            “BankAccount” class: 
                Variables (Attributes):
                    a. first name
                    b. last name
                    c. yearly interest rate
                    d. balance

                Functions (Methods):
                    1. default constructor
                    2. constructor with one parameter (yearly interest rate)
                    3. properties
         */
public BankAccount() //default ctor
        {
            FirstName = "";
            LastName = "";
            YearlyInterest = 0;
            Balance = 0.0;
        }

        public BankAccount(double i) //args ctor
        {
            FirstName = "";
            LastName = "";
            YearlyInterest = i;
            Balance = 0.0;

        }

        //just making everything public
        //honestly balance should probably be private in a real application
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double YearlyInterest { get; set; }

        public double Balance { get; set; }
    }
}
