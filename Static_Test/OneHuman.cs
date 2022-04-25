using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Test
{
     class OneHuman
    {
        public static string name; /*{ get; set; }*/ //при статике не может быть приватный ибо в программе не сделать отссылку
        public static int age; /*{ get; set; }*/

        public static string Name //тоже самое что и { get; set; }
        {
            get { return name; }
            set { name = value; }
        }
        public static int Age //тоже самое что и { get; set; }
        {
            get { return age; }
            set { age = value; }
        }


        public static string GetInformation()
        {
            return string.Format("{0} is {1} years old", name, age);
        }
    }
}
