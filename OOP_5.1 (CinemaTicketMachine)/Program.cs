using System;

namespace _1._04_Figure
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rec1 = new Rectangle();
            Console.WriteLine(rec1);
            Rectangle rec2 = new Rectangle(5, 10);
            Console.WriteLine(rec2);
            Console.WriteLine(rec2.Area());
            Console.ReadKey();

        }
    }
}
