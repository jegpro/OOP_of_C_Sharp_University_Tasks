using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{
    class Engineer
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

        public float CalculateCharge(float hour) // using type *float* need to use (number)*f*
        {
            return billingRate * hour;
        }
        public string TypeName()
        {
            return "Engineer";
        }
    }
}
