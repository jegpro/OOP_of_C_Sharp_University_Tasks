using System;


namespace VirtualMethodDemo
{
    class VProgram
    {
        static void Main(string[] args)
        {
            /* 
           25.5f
           25.5F
           (float)25.5 
           */

            Engineer engineer = new Engineer("Gogi San", 25.50f); // using type *float* need to use (number)*f*
            Console.WriteLine("Name is : {0} - Sum : {1} EUR", engineer.TypeName(), engineer.CalculateCharge(40f));

            CivilEngineer civilengineer = new CivilEngineer("Garik Marterosjan", 100f);
            Console.WriteLine("Name is : {0} - Sum : {1} EUR", civilengineer.TypeName(), civilengineer.CalculateCharge(0.75f));

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            /*****************************************/

            Engineer[] arrayE = new Engineer[3];
            arrayE[0] = new Engineer("Tom", 25f);
            arrayE[1] = new CivilEngineer("Bob", 100f);
            arrayE[2] = new ChemicalEngineer("John", 133.30f);

            /*
            ошибка из-за того, что все скрываемые методы определяются по базовому типу Engineer[] arrayE
             */


            for (int i = 0; i < arrayE.Length; i++)
            {
                Console.WriteLine("Name is : {0} - Sum : {1:f2} EUR", arrayE[i].TypeName(), arrayE[i].CalculateCharge(0.75f));
            }


            Console.ReadKey();
        }
    }
}
