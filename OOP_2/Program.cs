using System;
using MyLibrary;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyConsole.StartCyrillic();


            Student student1 = new Student();
            Student student2 = new Student("Vasja Pupkin", "39905060000");

            Console.WriteLine(student1);  //
            Console.WriteLine(student2);  //


            MyConsole.Pause();
        }
    }
}
