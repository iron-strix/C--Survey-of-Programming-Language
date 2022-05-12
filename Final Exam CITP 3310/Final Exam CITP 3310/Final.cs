//Nigel Little
//CITP 3310v03
//05/11/2022

using System;

namespace Final_Exam_CITP_3310
{
    class Final
    {
        static void Main(string[] args)
        {
            
            //create array and fill it with the data from file
            //student objects are initialized from within GetDataFromFile
            Student[] students = GetDataFromFile();
            
            //store results to pass to DisplayGradeDistribution
            double[] results = CalcResults(students);

            //display results
            DisplayGradeDistribution(students, results);
        }

        //fetches data line by line from "input.txt"
        //returns an array of Students, since each grade is the grade a of student
        //no data needs to be given as the file is accessible from within the method
        static Student[] GetDataFromFile()
        {
            //create array to return and initialize all the student objects
            Student[] students = new Student[20];

            //loop to initialize all elements
            for(int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }

            //to enable indexing of student array
            int index = 0;

            //read file line by line and store into array
            foreach (string line in System.IO.File.ReadLines(@"..\..\..\input.txt")) //relative path, only works in the IDE/Debug environment though
            {
                double lineNum = Double.Parse(line); //try to convert to double

                //store student's grade
                students[index].grade = lineNum;

                //increment index to get next student
                index++;
            }

            //return the array
            return students;
        }

        //needs to access the array of Student created prior
        //to calculate the lowest, highest, and average grades
        //returns a 3 element array of doubles to pass these results to main
        static double[] CalcResults(Student[] students)
        {
            //double array to store the results of lowest, highest, and average grades
            //index 0 = lowest
            //index 1 = highest
            //index 2 = avg
            double[] results = new double[3] {100, 0, 0};

            //necessary to calculate average
            double sum = 0;

            //interate through students and check their grades for highest or lowest
            foreach(Student i in students)
            {
                //check for lowest value in array of students
                if(results[0] > i.grade)
                {
                    results[0] = i.grade;
                }

                //check for highest value in array of students
                if(results[1] < i.grade)
                {
                    results[1] = i.grade;
                }

                //sum is equal to all previous plus current student
                sum = sum + i.grade;
            }

            //calculate average based on sum
            results[2] = sum / (students.Length);

            return results;
        }

        //returns no value, just displays to console and figures out a distribution of grades to display
        //needs student array and results to display
        static void DisplayGradeDistribution(Student[] students, double[] results)
        {
            //determine grade distribution
            //create array to keep track of different distributions
            //0:0-59, 1:60-69, 2:70-79, 3:80-89, 4:90-100
            int[] distributions = new int[5];

            //loop thru data, checking values
            //else ifs to prevent unecessary checks
            foreach (Student i in students)
            {
                //0-59 check
                if(i.grade <= 59)
                {
                    //if found, increase count
                    distributions[0] = distributions[0] + 1;
                }

                //60-69 check
                else if(i.grade <= 69 && i.grade > 59)
                {
                    //if found, increase count
                    distributions[1] = distributions[1] + 1;
                }

                //70-79 check
                else if (i.grade <= 79 && i.grade > 69)
                {
                    //if found, increase count
                    distributions[2] = distributions[2] + 1;
                }

                //80-89 check
                else if (i.grade <= 89 && i.grade > 79)
                {
                    //if found, increase count
                    distributions[3] = distributions[3] + 1;
                }

                //90-100 check
                else if (i.grade <= 100 && i.grade > 89)
                {
                    //if found, increase count
                    distributions[4] = distributions[4] + 1;
                }
            }

            //print results
            Console.WriteLine("Lowest\t\tHighest\t\tAverage");
            Console.WriteLine("{0}\t\t{1}\t\t{2}", results[0], results[1], results[2]);
            Console.Write("\n\n\n");

            //print distribution
            Console.WriteLine("Grade Distribution\n");
            Console.WriteLine("0~59\t:  {0}", distributions[0]);
            Console.WriteLine("60~69\t:  {0}", distributions[1]);
            Console.WriteLine("70~79\t:  {0}", distributions[2]);
            Console.WriteLine("80~89\t:  {0}", distributions[3]);
            Console.WriteLine("90~100\t:  {0}\n\n", distributions[4]);
        }
    }
}