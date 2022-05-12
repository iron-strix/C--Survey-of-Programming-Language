//Nigel Little
//CITP 3310 v03
//Exam2
//04/03/2022

using System;

namespace Exam2
{
    class StudentInfoTest
    {
        static void Main(string[] args)
        {
            const double minimumGrade = 0;
            const double maximumGrade = 100;
            //prompts the user to enter name and three grades between 0 and 100 (include input validation).
            
            //get first name
            Console.WriteLine("Please enter the student's first name: ");
            string first = Console.ReadLine();
            while (string.IsNullOrEmpty(first))
            {
                Console.WriteLine("First name can't be empty. Please try again: ");
                first = Console.ReadLine();
            }

            //get last name
            Console.WriteLine("Please enter the student's last name: ");
            string last = Console.ReadLine();
            while (string.IsNullOrEmpty(last))
            {
                Console.WriteLine("Last name can't be empty. Please try again: ");
                last = Console.ReadLine();
            }

            //get grades
            Console.WriteLine("Please enter the student's Exam 1 grade: ");
            double exam1 = Convert.ToDouble(Console.ReadLine());
            while(!BetweenRanges(minimumGrade, maximumGrade, exam1))
            {
                Console.WriteLine("Value entered for Exam 1 is not a number between 0 and 100. Please try again.");
                exam1 = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Please enter the student's Exam 2 grade: ");
            double exam2 = Convert.ToDouble(Console.ReadLine());
            while (!BetweenRanges(minimumGrade, maximumGrade, exam2))
            {
                Console.WriteLine("Value entered for Exam 2 is not a number between 0 and 100. Please try again.");
                exam2 = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Please enter the student's Exam 3 grade: ");
            double exam3 = Convert.ToDouble(Console.ReadLine());
            while (!BetweenRanges(minimumGrade, maximumGrade, exam3))
            {
                Console.WriteLine("Value entered for Exam 3 is not a number between 0 and 100. Please try again.");
                exam3 = Convert.ToDouble(Console.ReadLine());
            }

            //create objects
            StudentInfo studentNone = new StudentInfo();
            studentNone.FirstName = first;
            studentNone.LastName = last;
            studentNone.Exam1 = exam1;
            studentNone.Exam2 = exam2;
            studentNone.Exam3 = exam3;

            StudentInfo studentAll = new StudentInfo(first, last, exam1, exam2, exam3);

            //display
            Console.WriteLine("\nUsing default constructor:");
            Console.WriteLine("Student Name: {0} {1}\nExam1: {2}\nExam2: {3}\nExam3: {4}\nAverage: {5:0.00}\nLetter grade: {6}\n",
                studentNone.FirstName, studentNone.LastName, studentNone.Exam1, studentNone.Exam2, studentNone.Exam3, studentNone.calculateAve(), studentNone.getLetterGrade());

            Console.WriteLine("\nUsing passed info constructor:");
            Console.WriteLine("Student Name: {0} {1}\nExam1: {2}\nExam2: {3}\nExam3: {4}\nAverage: {5:0.00}\nLetter grade: {6}\n",
                studentAll.FirstName, studentAll.LastName, studentAll.Exam1, studentAll.Exam2, studentAll.Exam3, studentAll.calculateAve(), studentAll.getLetterGrade());
        }
        
        //method to check if values are between range 0 to 100
        public static bool BetweenRanges(double a, double b, double number)
        {
            return (a <= number && number <= b);
        }
    }
}
