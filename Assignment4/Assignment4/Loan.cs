//Nigel Little
//CITP 3310 v03
//Assignment 4
//03/01/22

using System;

namespace Assignment4
{
    class Loan
    {
        /* characteristics such as: 
         *      the amount to be financed, 
         *      rate of interest, 
         *      period of time for the loan, 
         *      and total interest paid 
         *  will identify the current state of a loan object.
        */
        public Loan() //default ctor
        {
            Principle = 0;
            InterestRate = 0;
            Period = 0;
        }
        public Loan(double p, double i, int t) //double Principle, double InterestRate, int Period
        {
            Principle = p;
            InterestRate = i;
            Period = t;
        }

        private double monthlyInterestRate;
        private double monthlyPeriod;
        public double Principle { get; set; }

        public double InterestRate { get; set; }

        public int Period { get; set; }

        /*Include methods to determine the:
         *      monthly payment amount, 
         *      return the total interest paid over the life of the loan, 
         *      and Loantable function to display an amortization schedule that includes: 
         *          number of the cycle, 
         *          payment amount, 
         *          principal paid, 
         *          interest paid, 
         *          total interest paid, 
         *          balance
        */

        //return monthly payment amount
        public double MonthlyPayment() {
            //call to derive monthly values, since the finance formula needs monthly values
            UpdateMonthly();

            double payment = Principle * ((monthlyInterestRate * (Math.Pow((1 + monthlyInterestRate), monthlyPeriod)) / ((Math.Pow((1 + monthlyInterestRate), monthlyPeriod)) -1)));
            return payment;
        }

        //return total amount of interest paid over the life of the loan
        public double InterestPaid()
        {

            double totalPaid = (MonthlyPayment()*monthlyPeriod) - Principle;
            return totalPaid;
        }

        //display number of the cycle, payment amount, principal paid, interest paid, total interest paid, and balance
        //should not modify loan object
        public void LoanTable() 
        {
            //create local variables to store values needed for calculations
            double principle = Principle;
            double monthlyPayment = MonthlyPayment();

            double monthlyInterestAccrued;
            double monthlyTowardsPrinciple;
            double totalInterest = 0;
            string month = "Month 0:";
            int count = 0;
            string divider = " | ";

            Console.WriteLine("Initial loan amount: ${0}\n", Principle.ToString("F"));
            Console.WriteLine("Initial loan period: {0} years\n", Period.ToString());
            Console.WriteLine("Initial loan APR: {0}%\n", InterestRate.ToString("F"));

            //header line1
            Console.WriteLine("\t{0,15}\t{1,15}\t{2,15}\t{3,15}\t{4,15}\t", 
                "Monthly", "Monthly to", "Monthly to", "Total", "Principle");
            //header line2
            Console.WriteLine("\t{0,15}\t{1,15}\t{2,15}\t{3,15}\t{4,15}\t",
                "Payment", "Interest", "Principle", "Interest", "Remaining");

            //principal * monthly interest = interest for month x
            //payment for month - interest for month x = payment towards principal
            //principal - payment towards principal = principal remaining
            for (int k = Convert.ToInt32(monthlyPeriod); k > 0; k--)
            {
                //count var needed since loop counts downward
                count++;
                month = "Month " + count + ":";

                //calculate monthly interest amount, total interest paid, amount paid towards principle, and the principle remaining
                monthlyInterestAccrued = principle * monthlyInterestRate;
                totalInterest += monthlyInterestAccrued;
                monthlyTowardsPrinciple = monthlyPayment - monthlyInterestAccrued;
                principle -= monthlyTowardsPrinciple;

                Console.WriteLine("{0,12} ${1,-9} {2,3} ${3,-9} {4,3} ${5,-9} {6,3} ${7,-9} {8,3} ${9,-9}", 
                        month, 
                        monthlyPayment.ToString("F"), divider,
                        monthlyInterestAccrued.ToString("F"), divider,
                        monthlyTowardsPrinciple.ToString("F"), divider,
                        totalInterest.ToString("F"), divider,
                        principle.ToString("F")
                    );
            }
        }

        //helper method to derive the monthly values of period and interestrate, since normally loans are input as yearly (APR and period)
        private void UpdateMonthly()
        {
            monthlyInterestRate = ((InterestRate / 12) / 100);
            monthlyPeriod = Period * 12;
        }
    }
}
