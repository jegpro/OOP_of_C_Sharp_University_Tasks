using System;

namespace Static_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            OneHuman.Name = "Jegor Pronkin";
            OneHuman.Age = 23;

            Console.WriteLine(OneHuman.GetInformation());
        }
    }
}
