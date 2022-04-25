using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethodDemo
{
    class CivilEngineer : Engineer
    {
        public CivilEngineer(string name, float billingRate) : base(name, billingRate)
        {
            Console.WriteLine("\nconstructor " + TypeName());
        }

        ~CivilEngineer()
        {
            Console.WriteLine("Destructor ~CivilEngineer\n");
        }

        public override float CalculateCharge(float hour)
        {
            if (hour < 1) 
            {
                hour = 1;
            }  

            return billingRate * hour;
        }
        public override string TypeName()
        {
            return "CivilEngineer";
        }
    }
}
