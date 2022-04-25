using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethodDemo
{
    abstract class Engineer
    {
        private string name;
        protected float billingRate;

        public Engineer()
        {

        }

        public Engineer(string name, float billingRate) // using type *float* need to use (number)*f*
        {
            this.name = name;
            this.billingRate = billingRate;
            Console.WriteLine("\nconstructor public Engineer() " + TypeName());
        }

        ~Engineer()
        {
            Console.WriteLine("Destructor ~Engineer\n");
        }

        public virtual float CalculateCharge(float hour) // using type *float* need to use (number)*f*
        {
            return billingRate * hour;
        }
        abstract public string TypeName();

        //public virtual string TypeName()
        //{
        //    return "Engineer";
        //}
    }
}
