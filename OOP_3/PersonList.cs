using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class PersonList
    {
        List<Person> list;

        public PersonList()
        {
            list = new List<Person>();
        }

        public bool Add(Person person)// Делает проверку на совпадение объекта, если совпадлений нет, то добавляет объект
        {
            foreach (Person p in list)
            {
                if (p.Equals(person))
                {
                    return false;
                }
            }
            list.Add(person);
            return true;
        }//end Add

        public void PrintListPerson()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                foreach (Person p in list)
                {
                    Console.WriteLine(p);
                }
            }
            Console.WriteLine();
        }
    }
}
