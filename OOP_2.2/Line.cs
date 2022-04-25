using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo_1
{
    class Line : IComparable //Класс Line реализует (имплементирует) интерфейс IComparable
                             //задаем "правила" сравнения/сортировки объектов



    //: Object //- по умолчанию любой класс 
    //является наследником класса Object
    {
        // объявляем переменную класс/поле класса 
        //- все поля класса должны быть private
        //int length; //- если модификаторы доступа не указаны явно,
        // то по умолчанию переменная получает статус private
        private int length;

        //propierties - свойства класса
        // - открыто для чтения (get)
        // - санкционированное изменение значения закрытой переменной (set)

        public int Length
        {
            get { return length; }

            //set { length = value; }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    //изменяем значение закрытой переменной только,
                    //если новое значение > 0
                    length = value;
                }
                else
                {
                    Console.WriteLine(
                        "Error: Length < 0 || Length >50 ; length = {0}",
                        length);
                }
            }
        }


        //constructor
        //public Line(int len)
        //{
        //    length = len;
        //    Console.WriteLine("constructor");
        //}

        public Line(int length)
        {
            //if (length > 0)
            //{
            //    this.length = length;  //!!! this.length
            //}

            this.Length = length; //set  

            Console.WriteLine("constructor");
        }

        //переопределяем конструктор по умолчанию
        public Line()
        {
            length = 1;
            Console.WriteLine("constructor");
        }


        //функциональность класса - открытые методы
        public void PrintState()
        {
            Console.WriteLine("Line: length = {0,3}", length);
        }

        public void Draw()
        {
            for (int i = 1; i <= length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // переопределение метода ToString() базового класса Object
        public override string ToString()
        {
            // return String.Format("Line: {0,3}", length);

            //C# ver 7.0
            return String.Format("{0}: {1,3}", nameof(length), length);
        }

        public int CompareTo(object obj) //задаем "правило" сравнения/сортировки объектов
        {
            Line temp = (Line)obj;

            //if (this.length == temp.length)
            //    return 0;
            //if (this.length > temp.length)
            //    return 1;
            //return -1;

            return this.length.CompareTo(temp.length);


        }

        //destructor
        ~Line()
        {
            Console.WriteLine("\n\ndestructor");
        }

    }
}
