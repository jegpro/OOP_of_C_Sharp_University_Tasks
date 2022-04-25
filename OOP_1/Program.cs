using System;
using MyLibrary;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем объект класса Line с использованием
            //конструктора по умолчанию

            Line line1 = new Line();
            line1.PrintState();


            Line line2 = new Line(15);
            line2.PrintState();

            Line line3 = new Line(-15); //0 error
            line3.PrintState();

            int dlina = line3.Length; // get 
            Console.WriteLine("line3 = {0}", dlina);  // 0

            Console.WriteLine("line1 = {0}", line1.Length);  //1  //get

            line1.Length = 25;  //set  1 -> 25 (value = 25)
            Console.WriteLine("line1 = {0}", line1.Length);  //25 //get

            line1.Length = -25;  //set  error!!!
            Console.WriteLine("line1 = {0}", line1.Length);  //25  get

            line1.Draw();
            line2.Draw();
            Console.WriteLine();

            for (int i = 1; i <= 8; i++)
            {
                line1.Length = i;  //set
                line1.Draw();
            }
            //***************************

            Console.WriteLine();

            int xx = 255;
            Console.WriteLine(xx);  //255
            //Console.WriteLine(xx.ToString());

            Console.WriteLine();
            //***************************

            Console.WriteLine(line1);  //ToString();
            Console.WriteLine(line2);  //ToString();
            //Console.WriteLine(line2.ToString());  //ToString();

            line1 = null;

            Console.ReadKey();
        }
    }
}
