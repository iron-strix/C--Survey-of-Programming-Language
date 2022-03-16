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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class EmployeeTest
    {
        public static void Main(string[] args)
        {
            Employee nigel = new Employee();
            nigel.FirstName ="Nigel";
            nigel.LastName = "Little";
            nigel.MonthlySalary = 3000.00;
            nigel.MonthlySalary = -1000.00; //test negative salary

            Employee tom = new Employee("Tom", "Keller", 4500.00);

            //display employees
            Console.WriteLine(nigel.FirstName + " " + nigel.LastName);
            Console.WriteLine("Monthly Salary: ${0}", nigel.MonthlySalary.ToString("F"));
            Console.WriteLine("Yearly Salary: ${0}", CalculateYearlySalary(nigel.MonthlySalary).ToString("F"));

            Console.WriteLine("\n" + tom.FirstName + " " + tom.LastName);
            Console.WriteLine("Monthly Salary: ${0}", tom.MonthlySalary.ToString("F"));
            Console.WriteLine("Yearly Salary: ${0}", CalculateYearlySalary(tom.MonthlySalary).ToString("F"));

            //give them each a 10% raise
            Console.WriteLine("\nGiving each employee a 10% raise...");
            nigel.MonthlySalary = (nigel.MonthlySalary * 1.1);
            tom.MonthlySalary = (tom.MonthlySalary * 1.1);
            Console.WriteLine("Raise given!\n");

            //display employees with raise
            Console.WriteLine(nigel.FirstName + " " + nigel.LastName);
            Console.WriteLine("Monthly Salary: ${0}", nigel.MonthlySalary.ToString("F"));
            Console.WriteLine("Yearly Salary: ${0}", CalculateYearlySalary(nigel.MonthlySalary).ToString("F"));

            Console.WriteLine("\n" + tom.FirstName + " " + tom.LastName);
            Console.WriteLine("Monthly Salary: ${0}", tom.MonthlySalary.ToString("F"));
            Console.WriteLine("Yearly Salary: ${0}", CalculateYearlySalary(tom.MonthlySalary).ToString("F"));
        }
        static double CalculateYearlySalary(double monthly)
        {
            return monthly * 12;
        }
    }
}
