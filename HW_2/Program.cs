using System;
using System.Collections;
using System.Collections.Generic;

namespace HW_2
{
    class Program
    {

        //########################### | То, что начали делать на лекции (доделанная дома) | ###########################

        static void Main(string[] args)
        {
            Person person1 = new Person("Georgi", "Prelovksi", "39702138554");
            //Console.WriteLine(person1);

            Person person2 = new Person("Ilja", "Lushpajev", "39702130011");
            //Console.WriteLine(person2);

            Person person3 = new Person("Anatoli", "Pokemon", "38112230644");
            //Console.WriteLine(person3);

            Person person4 = new Person("Irina", "Melnikova", "48703250445");
            //Console.WriteLine(person4);

            Person person5 = new Person("Angela", "Smith", "44501023144");
            //Console.WriteLine(person5);

            //Person person6 = new Person("Angel1a", "Sm1ith", "44501023144");
            ////Console.WriteLine(person6);

            #region классная работа

            //Console.WriteLine();
            //Console.WriteLine();

            //Person[] arrayPerson = { person1, person2, person3, person4,
            //    new Person("John", "Wick", "35502113322") };

            ////for (int i = 0; i < arrayPerson.Length; i++)
            ////{
            ////    Console.WriteLine(arrayPerson[i]);
            ////}
            //foreach (Person pers in arrayPerson)
            //{
            //    Console.WriteLine(pers);
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //Array.Sort(arrayPerson);

            //foreach (Person pers in arrayPerson)
            //{
            //    Console.WriteLine(pers);
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //foreach (Person pers in arrayPerson)
            //{
            //    //Console.WriteLine(pers);
            //    if (pers.Equals(person5))
            //    {
            //        Console.WriteLine("ok!");
            //        break;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //Array.Reverse(arrayPerson);

            //foreach (Person pers in arrayPerson)
            //{
            //    Console.WriteLine(pers);
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("ArrayPerson.Length = {0}", arrayPerson.Length);

            //Console.WriteLine();
            //Console.WriteLine();

            ////демонстрация использования класса ArrayList


            //ArrayList arrayList = new ArrayList();
            //// ArrayList arrayList new ArrayList();
            //arrayList.Add(35); arrayList.Add(15); arrayList.Add(25);

            ////int size = arrayList.Count;
            ////Console.WriteLine("size = {0}", size);

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("ArrayList : ");
            //PrintArrayList(arrayList);

            //Console.WriteLine(" Sort : ");
            //arrayList.Add(2.5);
            //// arrayList.Sort();
            //PrintArrayList(arrayList);

            //arrayList.Add(person1);

            //PrintArrayList(arrayList);

            //arrayList.Clear();
            //int size = arrayList.Count;
            //Console.WriteLine("size = {0}", size);

            //arrayList.Add(100); arrayList.Add(11); arrayList.Add(1001); arrayList.Add(12);

            //PrintArrayList(arrayList);

            //arrayList.Remove(11);
            //PrintArrayList(arrayList);

            //arrayList.RemoveAt(1);
            //PrintArrayList(arrayList);

            //arrayList.Add(55);

            //arrayList.Insert(0, 111);

            //PrintArrayList(arrayList);

            //Object[] array = arrayList.ToArray();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //arrayList.Add("Pupa");
            //arrayList.Add("Lupa");
            //arrayList.Add(8);
            //arrayList.Add(3.5);

            //PrintArrayList(arrayList);

            //int ii = 0;
            //while (ii < arrayList.Count)
            //{
            //    if (arrayList[ii] is string)
            //    {
            //        arrayList.Remove(arrayList[ii]);
            //        ii--;
            //    }
            //    else
            //    {
            //        if (arrayList[ii] is double)
            //        {
            //            arrayList.Remove(arrayList[ii]);
            //            ii--;
            //        }
            //    }


            //    ii++;

            //}
            //PrintArrayList(arrayList);

            //Console.WriteLine();

            //***********************
            //List<int> list = new List<int>();
            //list.Add(25);
            //list.Add(3);
            //list.Add(44);
            //PrintArrayList(list);
            //Console.WriteLine();

            //List<Person> listPerson = new List<Person>();

            //listPerson.Add(person1);
            //listPerson.Add(person2);
            //listPerson.Add(person3);
            //listPerson.Add(person4);
            //listPerson.Add(person5);
            //listPerson.Sort();
            //PrintArrayList(listPerson);

            //***********************************************
            #endregion

            PersonList personList = new PersonList();

            Console.WriteLine("COUNT PERSON : {0}", personList.CountPerson); ///****
            Console.WriteLine();

            Console.WriteLine(personList.Add(person3));
            Console.WriteLine(personList.Add(person1));
            Console.WriteLine(personList.Add(person2));
            Console.WriteLine(personList.Add(person4));
            Console.WriteLine(personList.Add(person5));
            //Console.WriteLine(personList.Add(person6)); //одинаковые данные
            Console.WriteLine();

            personList.PrintListPerson(); //содержимое массива
            Console.WriteLine("COUNT PERSON : {0}", personList.CountPerson); ///кол-во в массиве
            Console.WriteLine();

            personList.Delete(person1);
            //personList.Delete(person2);

            personList.PrintListPerson(); //count 4. count 3 if uncomment "personList.Delete(person2);"
            Console.WriteLine("COUNT PERSON : {0}", personList.CountPerson); ///кол-во в массиве
            Console.WriteLine();



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
        public static void PrintArrayList(System.Collections.Generic.List<Person> arr)

        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine("{0,5}", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
