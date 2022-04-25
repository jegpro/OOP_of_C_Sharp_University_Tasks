using System;

namespace UsingComposition
{
    class Employee
    {
        string firstName;
        string lastName;
        Date birthDate; //reference to a Date object
        Date hireDate;  //reference to a Date object

        public Employee(string firstName, string lastName, int bDay, int bMonth, int bYear, int hDay, int hMonth, int hYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            birthDate = new Date(bMonth, bDay, bYear);
            hireDate = new Date(hMonth, hDay, hYear);
        }

        public override string ToString() {
            return String.Format(
         "{0,-15} {1,-15} Hired :{2} Birthday :{3}",
          lastName, firstName, hireDate, birthDate);
        }
    }
}
