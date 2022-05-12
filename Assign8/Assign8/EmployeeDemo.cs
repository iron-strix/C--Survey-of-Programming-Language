//Nigel Little
//CITP 3310v03
//04/16/2022

using System;
using System.IO; //needed for file reading

namespace Assign8
{
    class EmployeeDemo
    {
        static void Main(string[] args)
        {
            //create employees
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            Employee[] employees = new Employee[3]; //create array of employees
            employees[0] = emp1;
            employees[1] = emp2;
            employees[2] = emp3;

            Console.Write("This program will demo the Employee class." +
                "\n3 Employees have been created and this program will calculate their salaries based on tenure." +
                "\nIf their salary is within a desired range it will be displayed.\n");

            //prompt for year
            int year;
            Console.Write("Enter the current year: ");
            int.TryParse(Console.ReadLine(), out year);

            //open file
            StreamReader reader = new StreamReader(@"..\..\..\EmployeeInfo.txt"); //relative path, only works in the IDE/Debug environment though

            int employeeNumber = 0; //used to track which employee currently reading/writing

            //write data into employees
            while (!reader.EndOfStream)
            {
                //first
                string line = reader.ReadLine(); //will take file line by line
                employees[employeeNumber].FirstName = line;

                //last
                line = reader.ReadLine();
                employees[employeeNumber].LastName = line;

                //id
                line = reader.ReadLine();
                employees[employeeNumber].IDNumber = line;

                //startyear
                line = reader.ReadLine();
                int lineNum = Int32.Parse(line); //try to convert to int
                employees[employeeNumber].StartYear = lineNum;

                //initial salary
                line = reader.ReadLine();
                double lineDouble = Double.Parse(line); //try to convert to double
                employees[employeeNumber].InitialSalary = lineDouble;

                //calculate current employee's salary based on given year
                employees[employeeNumber].CalcCurSalary(year);

                //increment employee in array
                employeeNumber++;
            }

            //display info
            //prompt for salary range
            double maxSalary, minSalary;

            Console.WriteLine("Enter employee salary range to search: ");
            Console.Write("Maximum: ");
            double.TryParse(Console.ReadLine(), out maxSalary);
            Console.Write("Minimum: ");
            double.TryParse(Console.ReadLine(), out minSalary);

            for (int i=0; i < employees.Length; i++)
            {
                //Console.WriteLine("DEBUG:");
                //Console.WriteLine("Employee Name: " + employees[i].FirstName + " " + employees[i].LastName +
                        //"\nEmployeeID: " + employees[i].IDNumber + "\nEmployee’s current Salary: " + employees[i].CurrentSalary);
                if (employees[i].CurrentSalary <= maxSalary && employees[i].CurrentSalary >= minSalary)
                {
                    Console.WriteLine("\nEmployee Name: " + employees[i].FirstName + " " + employees[i].LastName + 
                        "\nEmployeeID: " + employees[i].IDNumber + "\nEmployee’s current Salary: $" + employees[i].CurrentSalary.ToString("F") + "\n");
                }
            }
        }
    }
}