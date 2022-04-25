using System;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Rectangle rect1 = new Rectangle();
            rect1.DrawFill();
            Rectangle rect2 = new Rectangle(25, 50);
            rect2.DrawFill();
            Rectangle rect3 = new Rectangle(-5, -2);
            rect3.DrawFill();
            Console.WriteLine("Area1: {0,3}\nLength: {1,3}\nWidth: {2,3}",
                rect1.Area(), rect1.Length, rect1.Width);
            Console.WriteLine();
            Console.WriteLine("Area2: {0,3}\nLength: {1,3}\nWidth: {2,3}",
                rect2.Area(), rect2.Length, rect2.Width);
            Console.WriteLine();
            Console.WriteLine("Area3: {0,3}\nLength: {1,3}\nWidth: {2,3}",
                rect3.Area(), rect3.Length, rect3.Width);
            rect1.Draw();
            Console.WriteLine();
            Console.WriteLine(rect1);
            Console.WriteLine(rect2);
            Console.WriteLine(rect3);
            Console.WriteLine("Area2: {0,3}\n{1}",
                rect2.Area(), rect2);
            Console.ReadKey();
        }
    }
}
