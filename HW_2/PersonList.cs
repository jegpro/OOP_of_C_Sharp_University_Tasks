using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2
{
    public class PersonList
    {
        List<Person> list;

        public PersonList()
        {
            list = new List<Person>();
        }

        public int CountPerson
        {
            get { return list.Count; }
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

        public void Delete(Person person)
        {
            list.Remove(person);
        }

        public void PrintListPerson()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("LIST IS EMPTY");
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
