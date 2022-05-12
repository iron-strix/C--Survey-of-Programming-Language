//Nigel Little
//CITP 3310 v03
//Assignment 6
//03/27/2022

using System;

namespace Assign6
{
    class PersonTest
    {
        static void Main(string[] args)
        {
            //default ctor no values initialized whatsoever
            Person person = new Person();
            Console.WriteLine("USING DEFAULT CTOR:");
            TestPerson(person);

            //set all ctor
            Person personAll = new Person("John", "Doe", 1990, 10, 22, (2022 - 1990));
            Console.WriteLine("USING ALL CTOR:");
            TestPerson(personAll);

            //set first and last ctor
            Person personFirstLast = new Person("Pradip", "Mulji");
            personFirstLast.Age = 60; //manually set age
            Console.WriteLine("USING FIRST+LAST CTOR:");
            TestPerson(personFirstLast);

            //set first, last, and age ctor
            Person personFirstLastAge = new Person("Nigel", "Little", 70);
            //manually set dates
            personFirstLastAge.DayOfBirth = 29;
            personFirstLastAge.MonthOfBirth = 10;
            personFirstLastAge.YearOfBirth = 2022 - personFirstLastAge.Age;
            Console.WriteLine("USING FIRST+LAST+AGE CTOR:");
            TestPerson(personFirstLastAge);

            //now some try catch with invalid values
            try
            {
                //set all ctor with invalid month
                Person allError = new Person("John", "Doe", 1990, -1, 22, (2022 - 1990));
                Console.WriteLine("USING ALL CTOR:");
                TestPerson(allError);
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        static void TestPerson(Person person)
        {
            Console.WriteLine("First: {0,10}\tLast: {1,10}" +
                "\nDay of Birth: {2,2}\tMonth: {3,2}\tYear: {4,4}" +
                "\nAge: {5,2}",
                person.FirstName, person.LastName, person.DayOfBirth,
                person.MonthOfBirth, person.YearOfBirth, person.Age);

            Console.WriteLine("Is Adult? - {0}", person.IsAdult());
            Console.WriteLine("Western Sun Sign: {0}", person.WesternSunSign());
            Console.WriteLine("Chinese Zodiac Sign: {0}\n", person.ChineseZodiacSign());
        }
    }
}
