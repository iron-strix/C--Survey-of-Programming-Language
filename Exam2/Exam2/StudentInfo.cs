//Nigel Little
//CITP 3310 v03
//Exam2
//04/03/2022

using System;

namespace Exam2
{
    class StudentInfo
    {
        //ctors
        public StudentInfo() { } //default sets none

        public StudentInfo (string first, string last, double exam1, double exam2, double exam3)
        {
            FirstName = first;
            LastName = last;
            Exam1 = exam1;
            Exam2 = exam2;
            Exam3 = exam3;
        }

        //attributes
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Exam1 { get; set; }
        public double Exam2 { get; set; }
        public double Exam3 { get; set; }

        private const int NumberOfExams = 3; //there are 3 exam grades

        //public methods
        public double calculateAve()
        {
            //average is sum of values in set divided by number of values in set
            double average = (Exam1 + Exam2 + Exam3) / NumberOfExams;
            return average;
        }

        public char getLetterGrade()
        {
            char letterGrade = ' ';
            
            if (calculateAve() >= 90)
            {
                letterGrade = 'A';
            }
            else if(calculateAve() >= 80)
            {
                letterGrade = 'B';
            }
            else if(calculateAve() >= 70)
            {
                letterGrade = 'C';
            }
            else if(calculateAve() >= 60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            return letterGrade;
        }
    }
}
