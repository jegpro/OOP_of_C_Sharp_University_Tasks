using System;

namespace TaskIStack
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack arraystack = new ArrayStack(5);
            Console.WriteLine(arraystack.Size());    //0

            Console.WriteLine(arraystack.IsEmpty());  // true

            try
            {
                arraystack.Push(6);
                arraystack.Push(7);
                arraystack.Push(2);
                arraystack.Push(1);
                arraystack.Push(0);
                arraystack.Push(-1);
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.WriteLine(arraystack.Size()); // 5
            Console.WriteLine(arraystack.IsEmpty()); //false
            
            Console.WriteLine(arraystack.Top());  //1

            while (!arraystack.IsEmpty())
            {
                Console.WriteLine("Pop() = {0} ",arraystack.Pop());
            }


            Console.WriteLine(arraystack.Size());  //0
            Console.WriteLine(arraystack.IsEmpty());  //true
            Console.ReadKey();
        }
    }
}
