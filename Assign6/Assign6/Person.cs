//Nigel Little
//CITP 3310 v03
//Assignment 6
//03/27/2022

using System;

namespace Assign6
{
    class Person
    {
        //ctors
        public Person() {} //default sets none

        //sets all
        public Person(string first, string last, int year, int month, int day, int age)
        {
            if (year < minimumDate)
                throw new ArgumentOutOfRangeException(nameof(year), $"Year must be greater than {minimumYear}.");
            
            if (month < minimumDate)
                throw new ArgumentOutOfRangeException(nameof(month), $"Month must be greater than {minimumDate}.");

            if (month > maximumMonth)
                throw new ArgumentOutOfRangeException(nameof(month), $"Month must be less than {maximumMonth + 1}.");

            if (day < minimumDate)
                throw new ArgumentOutOfRangeException(nameof(day), $"Day must be greater than {minimumDate}.");

            if (day > maximumDay)
                throw new ArgumentOutOfRangeException(nameof(day), $"Day must be less than {maximumDay + 1}.");

            if (age < minimumDate)
                throw new ArgumentOutOfRangeException(nameof(age), $"Age must be greater than {minimumDate}.");

            FirstName = first;
            LastName = last;
            YearOfBirth = year;
            MonthOfBirth = month;
            DayOfBirth = day;
            Age = age;
        }

        //sets first and last
        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        //sets first, last, and age
        public Person(string first, string last, int age)
        {
            if (age < minimumDate)
                throw new ArgumentOutOfRangeException(nameof(age), $"Age must be greater than {minimumDate}.");

            FirstName = first;
            LastName = last;
            Age = age;
        }

        private const int minimumDate = 0; //used to prevent negative dates
        private const int minimumYear = 1900;
        private const int maximumDay = 31; //can't be more than 31 days in a month
        private const int maximumMonth = 12; //can't be more than 12 months in a year

        //attributes
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _dayOfBirth;
        public int DayOfBirth { 
            get { return _dayOfBirth; }
            set
            {
                if (value < minimumDate)
                    throw new ArgumentOutOfRangeException(nameof(value), $"Day must be greater than {minimumDate}.");

                if (value > maximumDay)
                    throw new ArgumentOutOfRangeException(nameof(value), $"Day must be less than {maximumDay + 1}.");

                _dayOfBirth = value;
            }
        }

        private int _monthOfBirth;
        public int MonthOfBirth { 
            get { return _monthOfBirth; }
            set
            {
                if (value < minimumDate)
                    throw new ArgumentOutOfRangeException(nameof(value), $"Month must be greater than {minimumDate}.");

                if (value > maximumMonth)
                    throw new ArgumentOutOfRangeException(nameof(value), $"Month must be less than {maximumMonth + 1}.");

                _monthOfBirth = value;
            }
        }

        private int _yearOfBirth;
        public int YearOfBirth 
        { 
            get { return _yearOfBirth; }
            set
            {
                if (value < minimumDate)
                    throw new ArgumentOutOfRangeException(nameof(value), $"Year must be greater than {minimumYear}.");
               
                _yearOfBirth = value;
            }
        }

        private int _age;
        public int Age 
        { 
            get { return _age; }
            set
            {
                if (value < minimumDate)
                    throw new ArgumentOutOfRangeException(nameof(value), $"Age must be greater than {minimumDate}.");

                _age = value;
            }

        }

        //public methods

        //checks if person is 18 or older
        public bool IsAdult()
        {
            //since ints default to 0 in C#, I can assume uninit Age is 0
            //will try to find the age if date of birth has been set but no age given
            if(Age == 0)
            {
                int age = CalculateAge();
                if (age > 17)
                {
                    return true;
                }
            }
            else
            {
                if(Age > 17)
                {
                    return true;
                }
            }
            return false; //default case is false if under 17 for any reason
        }

        public string WesternSunSign()
        {
            string sign = "";

            //check if month and day of birth are initialized
            if (DayOfBirth != 0 && MonthOfBirth != 0)
            {
                //check dec
                if(MonthOfBirth == 12)
                {
                    if (DayOfBirth < 22)
                        sign = "Sagittarius";
                    else
                        sign = "Capricorn";
                }

                //check jan
                if (MonthOfBirth == 1)
                {
                    if (DayOfBirth < 20)
                        sign = "Capricorn";
                    else
                        sign = "Aquarius";
                }

                //check feb
                if (MonthOfBirth == 2)
                {
                    if (DayOfBirth < 19)
                        sign = "Aquarius";
                    else
                        sign = "Pisces";
                }

                //check march
                if (MonthOfBirth == 3)
                {
                    if (DayOfBirth < 21)
                        sign = "Pisces";
                    else
                        sign = "Aries";
                }

                //check april
                if (MonthOfBirth == 4)
                {
                    if (DayOfBirth < 20)
                        sign = "Aries";
                    else
                        sign = "Taurus";
                }

                //check may
                if (MonthOfBirth == 5)
                {
                    if (DayOfBirth < 21)
                        sign = "Taurus";
                    else
                        sign = "Gemini";
                }

                //check june
                if (MonthOfBirth == 6)
                {
                    if (DayOfBirth < 22)
                        sign = "Gemini";
                    else
                        sign = "Cancer";
                }

                //check july
                if (MonthOfBirth == 7)
                {
                    if (DayOfBirth < 23)
                        sign = "Cancer";
                    else
                        sign = "Leo";
                }

                //check aug
                if (MonthOfBirth == 8)
                {
                    if (DayOfBirth < 23)
                        sign = "Leo";
                    else
                        sign = "Virgo";
                }

                //check sept
                if (MonthOfBirth == 9)
                {
                    if (DayOfBirth < 23)
                        sign = "Virgo";
                    else
                        sign = "Libra";
                }

                //check oct
                if (MonthOfBirth == 10)
                {
                    if (DayOfBirth < 23)
                        sign = "Libra";
                    else
                        sign = "Scorpio";
                }

                //check nov
                if (MonthOfBirth == 11)
                {
                    if (DayOfBirth < 23)
                        sign = "Scorpio";
                    else
                        sign = "Sagittarius";
                }
            }
            else
            {
                sign = "Could not calculate the Western Sun Sign. Date of birth values are invalid.";
            }

            return sign;
        }

        public string ChineseZodiacSign()
        {
            string sign = "";

            //check if YearOfBirth is uninit
            if (YearOfBirth != 0)
            {
                switch ((YearOfBirth - 4) % 12)
                {
                    case 0:
                        sign = "Rat";
                        break;

                    case 1:
                        sign = "Ox";
                        break;

                    case 2:
                        sign = "Tiger";
                        break;

                    case 3:
                        sign = "Rabbit";
                        break;

                    case 4:
                        sign = "Dragon";
                        break;

                    case 5:
                        sign = "Snake";
                        break;

                    case 6:
                        sign = "Horse";
                        break;

                    case 7:
                        sign = "Goat";
                        break;

                    case 8:
                        sign = "Monkey";
                        break;

                    case 9:
                        sign = "Rooster";
                        break;

                    case 10:
                        sign = "Dog";
                        break;

                    case 11:
                        sign = "Pig";
                        break;
                }
            }
            else
            {
                sign = "Could not calculate the Chinese Zodiac Sign. Date of birth values are invalid.";
            }
            return sign;
        }
        public int CalculateAge()
        {
            //create DateTime objects
            //if dates are not set for person it will default to 0/0/0 which is OOR
            try
            {
                DateTime dateOfBirth = new DateTime(YearOfBirth, MonthOfBirth, DayOfBirth);
                DateTime now = DateTime.Now;

                //set age to current year minus birth year
                int age = now.Year - dateOfBirth.Year;

                //check months for leap year
                if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day))
                {
                    age--;
                }

                return age;
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ERROR: Date of birth is not a valid format. Age will default to 0.");
                return 0;
            }
        }
    }
}