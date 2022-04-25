using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2
{
    public class Person : IComparable
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
            return String.Format("{0,-10} {1,-10} ID:{2,-10} ", first_name, last_name, id_kod);

        }

        public override bool Equals(object obj)
        {
            Person temp = (Person)obj;

            return first_name == temp.first_name &&
                   last_name == temp.last_name &&
                   id_kod == temp.id_kod;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public int CompareTo(object obj)
        {
            Person temp = (Person)obj;

            return first_name.CompareTo(temp.FirstName);
        }

    }
}
