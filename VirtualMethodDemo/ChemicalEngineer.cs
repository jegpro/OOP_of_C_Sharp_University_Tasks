using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethodDemo
{
    class ChemicalEngineer : Engineer
    {
        public ChemicalEngineer(string name, float billingRate) : base(name, billingRate)
        {
            Console.WriteLine("\nconstructor " + TypeName());
        }

        ~ChemicalEngineer()
        {
            Console.WriteLine("Destructor ~ChemicalEngineer\n");
        }

        public override string TypeName()
        {
            return "ChemicalEngineer";
        }
    }
}
