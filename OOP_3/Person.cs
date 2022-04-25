using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class Person : IComparable //!!!!!!!
    {

        private string first_name, last_name, id_kod;

        public string FirstName
        {
            get { return first_name; }
        }

        public string LastName
        {
            get { return last_name; }
        }

        public string IdKod
        {
            get { return id_kod; }
        }

        public Person(string first_name, string last_name, string id_kod)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.id_kod = id_kod;
        }

        public override string ToString()
        {
            // return first_name + " " + last_name + "(ID: " + id_kod + ")";
            return String.Format("{0,-10} {1,-20} ID:{2,-11} ", first_name, last_name, id_kod);

        }

        public int CompareTo(object obj)
        {
            Person temp = (Person)obj;
            return first_name.CompareTo(temp.FirstName);
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   first_name == person.first_name &&
                   last_name == person.last_name &&
                   id_kod == person.id_kod;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(first_name, last_name, id_kod);
        }

        //public override int GetHashCode()
        //{
        //    throw new NotImplementedException();
        //}


    }
}
