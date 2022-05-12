//Nigel Little
//CITP 3310v03
//04/16/2022

namespace Assign8
{
    class Employee
    {
        //private fields
        private string firstName;
        private string lastName;
        private string idNumber;
        private double initialSalary;
        private int startYear;
        private double currentSalary;

        //ctors
        public Employee() //default ctor
        {
            firstName = "";
            lastName = "";
            idNumber = "";
            initialSalary = 0;
            startYear = 0;
            currentSalary = 0;
        }

        public Employee(string first, string last, string id, float initSalary, int start) //does not set current salary!
        {
            firstName = first;
            lastName = last;
            idNumber = id;
            initialSalary = initSalary;
            startYear = start;
        }

        //properties
        public string FirstName //can't use trivial getter/setter due to private backing fields
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string IDNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        public double InitialSalary
        {
            get { return initialSalary; }
            set { initialSalary = value; }
        }

        public int StartYear
        {
            get { return startYear; }
            set { startYear = value; }
        }

        public double CurrentSalary // read only, no setter
        {
            get { return currentSalary; }
        }

        //methods

        // given a year value, CalcCurSalary() will calculate current salary from start date to date given
        // 5% yearly increases from starting year
        public void CalcCurSalary(int targetYear) 
        {
            currentSalary = initialSalary; //used to set the starting pay

            for (int i = startYear; i <= targetYear; i++)
            {
                currentSalary += 0.05 * currentSalary; //each year pass will add an additional 5%
            }
        }
    }
}