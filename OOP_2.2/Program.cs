using System;
using ClassDemo_1;

namespace OOP_2._2
{
    class Program
    {
        static void Main(string[] args)
        {



            string[] name = { "Egor", "Boris", "Anna", "Oleg", "Ivan", "Lena", "Alik" };

            // Отобразить количество элементов в массиве
            // свойства Length

            Console.WriteLine(name.Length);

            //1 Отобразить содержимое массива

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Array.Sort(name); // сортирует по алфавиту

            //2 Отобразить содержимое осортированного массива с исп. перечислителя
            foreach (string s in name)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Array.Reverse(name);
            foreach (string s in name)
            {
                Console.WriteLine(s);

            }
            Console.WriteLine();

            //***********************************************

            int[] intArray = { 100, 5, 1, 0, 25 };
            foreach (int n in intArray)
            {
                Console.WriteLine(n);

            }
            Console.WriteLine();

            Array.Sort(intArray);
            foreach (int n in intArray)
            {
                Console.WriteLine(n);

            }
            Console.WriteLine();

            //***********************************************
            ////////////////LINE/////////////////////////////
            /////***********************************************

            Line[] arrayLine =
                {
                new Line(15), new Line(), new Line(5), new Line(25), new Line(10), new Line(20)
            };

            foreach(Line obj in arrayLine)
            {
                obj.Draw();
            }

            for (int i = 0; i < arrayLine.Length; i++)
            {
                //Console.WriteLine(arrayLine[i].ToString());
                Console.WriteLine(arrayLine[i]);
            }

            Array.Sort(arrayLine);
            foreach (Line obj in arrayLine)
            {
                obj.Draw();
            }




            Console.ReadKey();
        }
    }
}
