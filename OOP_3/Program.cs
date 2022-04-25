using System;
using System.Collections;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Vasja", "Pupkin", "38609213723");
            //Console.WriteLine(person1);

            Person person2 = new Person("Petja", "Vasechkin", "48201152223");
            //Console.WriteLine(person2);

            Person person3 = new Person("J", "Ivanov", "47201153223");
            //Console.WriteLine(person3);

            Person person4 = new Person("Ivan", "Ivanov", "47201153223");
            //Console.WriteLine(person4);
            Person person5 = new Person("Ivan", "Ivanov", "47201153223");
            //Console.WriteLine(person4);

            Console.WriteLine();
            Console.WriteLine();

            Person[] arrayPerson = { person1, person2, person3, person4,
                new Person("Anton", "Antonov", "49201132223") };

            //for (int i = 0; i < arrayPerson.Length; i++)
            //{
            //    Console.WriteLine(arrayPerson[i]);
            //}
            foreach (Person pers in arrayPerson)
            {
                Console.WriteLine(pers);
            }
            Console.WriteLine();
            Console.WriteLine();

            Array.Sort(arrayPerson);

            foreach (Person pers in arrayPerson)
            {
                Console.WriteLine(pers);
            }
            Console.WriteLine();
            Console.WriteLine();

            foreach (Person pers in arrayPerson)
            {
                //Console.WriteLine(pers);
                if (pers.Equals(person5))
                {
                    Console.WriteLine("OK");
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Array.Reverse(arrayPerson);

            foreach (Person pers in arrayPerson)
            {
                Console.WriteLine(pers);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("ArrayPerson.Length = {0}", arrayPerson.Length);

            Console.WriteLine();
            Console.WriteLine();

            //демонстрация использования класса ArrayList

            ArrayList arrayList;
            arrayList = new ArrayList();
            // ArrayList arrayList new ArrayList();
            arrayList.Add(35); arrayList.Add(15); arrayList.Add(25);

            //int size = arrayList.Count;
            //Console.WriteLine("size = {0}", size);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ArrayList : ");
            PrintArrayList(arrayList);

            Console.WriteLine(" Sort : ");
            arrayList.Add(2.5);
            // arrayList.Sort();
            PrintArrayList(arrayList);

            arrayList.Add(person1);

            PrintArrayList(arrayList);

            arrayList.Clear();
            int size = arrayList.Count;
            Console.WriteLine("size = {0}", size);

            arrayList.Add(100); arrayList.Add(10); arrayList.Add(1000); arrayList.Add(10);

            PrintArrayList(arrayList);

            arrayList.Remove(10);
            PrintArrayList(arrayList);

            arrayList.RemoveAt(1);
            PrintArrayList(arrayList);

            arrayList.Add(50);

            arrayList.Insert(0, 123);

            PrintArrayList(arrayList);

            Object[] array = arrayList.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            arrayList.Add("Lena");
            arrayList.Add("Sveta");
            arrayList.Add(5);
            arrayList.Add(5.5);

            PrintArrayList(arrayList);

            int ii = 0;
            while (ii < arrayList.Count)
            {
                if (arrayList[ii] is string)
                {
                    arrayList.Remove(arrayList[ii]);
                    ii--;
                }
                else
                {
                    if (arrayList[ii] is double)
                    {
                        arrayList.Remove(arrayList[ii]);
                        ii--;
                    }
                }


                ii++;

            }
            PrintArrayList(arrayList);

            Console.WriteLine();

            //***********************
            List<int> list = new List<int>();
            list.Add(15);
            list.Add(5);
            list.Add(55);
            //list.Add(1.1);
            //list.Add("lena");
            PrintArrayList(list);
            Console.WriteLine();

            List<Person> listPerson = new List<Person>();

            listPerson.Add(person1);
            listPerson.Add(person2);
            listPerson.Add(person3);
            listPerson.Add(person4);
            listPerson.Add(person5);
            listPerson.Sort();
            PrintArrayList(listPerson);

            //***********************************************

            PersonList personList = new PersonList();

            Console.WriteLine(personList.Add(person3));
            Console.WriteLine(personList.Add(person1));
            Console.WriteLine(personList.Add(person2));
            Console.WriteLine(personList.Add(person4));
            Console.WriteLine(personList.Add(person5));

            personList.PrintListPerson();




            Console.ReadKey();

        }//end Main

        public static void PrintArrayList(List<int> arr)

        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write("{0,5}", arr[i]);
            }
            Console.WriteLine();
        }
        public static void PrintArrayList(ArrayList arr)

        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write("{0,5}", arr[i]);
            }
            Console.WriteLine();
        }
        public static void PrintArrayList(List<Person> arr)

        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine("{0,5}", arr[i]);
            }
            Console.WriteLine();
        }

    }
    }
}
