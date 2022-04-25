using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
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

        new public float CalculateCharge(float hour)
        {
            if (hour < 1) 
            {
                hour = 1;
            }  

            return billingRate * hour;
        }
        new public string TypeName()
        {
            return "CivilEngineer";
        }
    }
}
