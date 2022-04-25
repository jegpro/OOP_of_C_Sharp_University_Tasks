using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Bob", "Jones", 24, 12, 1990, 1, 9, 2013);
            Console.WriteLine(e);

            //*****************************
            
            Employee e1 = new Employee("Jegor", "Pronkin", 25, 03, 1997, 15, 06, 2019);
            Console.WriteLine(e1);

            Console.ReadKey();
        }
    }
}
