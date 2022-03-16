/* Nigel Little
 * CITP 3310 - V03
 * 02/12/2022
 * 
 * Create a class called Employee that includes three pieces of information as instance variables 
 * — a first name (type string), 
 * a last name (type string) 
 * and a monthly salary (double). 
 * 
 * Your class should have two constructors, one default and one that initializes the three values. 
 * Provide the properties with a get and set accessor for all instance variables. 
 * If the monthly salary is negative, the set accessor should leave the instance variable unchanged. 
 *
 * Write a test application named EmployeeTest that demonstrates class Employee’s capabilities. 
 * Create two Employee objects and display each object’s yearly salary. 
 * Then give each Employee a 10% raise and display each Employee’s yearly salary again.
*/
using System;

namespace Assignment2
{
    class Employee
    {
        public Employee() //default ctor
        {
            FirstName = "";
            LastName = "";
            MonthlySalary = 0;
        }

        public Employee(string f, string l, double s) //args ctor
        {
            FirstName = f;
            LastName = l;
            MonthlySalary = s;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public double MonthlySalary
        {
            get {
                return _monthlySalary;
            }
            set
            {
                if (value >= 0)
                    _monthlySalary = value;
                else
                    Console.WriteLine($"{nameof(value)} given for MonthlySalary was less than 0.\n");
            }
        }

        private double _monthlySalary; //private backing field
    } 
}
