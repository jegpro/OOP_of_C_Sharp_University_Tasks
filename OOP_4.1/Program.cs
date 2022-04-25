using System;

namespace OOP_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            B ob1 = new B();
            ob1.Showij();

            B ob2 = new B(5, 10);
            ob1.Showij();

            D ob3 = new D();
            ob1.Showij();

            D ob4 = new D(10, 20, 30);
            ob1.Showij();
        }
    }

    /* 
     
     Добавьте отсутствующие конструкторы в данную программу    и внесите другие исправления: 

    */

    class B
    {
        protected int i, j;
        
        public B(int i, int j)
        {
            this.i = i;
            this.j = j;
        }

        public B()
        {
        }

        public void Showij()
        {
            Console.WriteLine("{0}\t{1}", i, j);
        }
    }
    class D : B
    {
        int k;

        public D(int k, int i, int j) : base(i, j)
        {
            this.k = k;
        }

        public D()
        {
        }

        public void Show()
        {
            Console.WriteLine("i ={0}\t j = {1}", i, j);
            Console.WriteLine("k ={0}", k);
        }
    }

}
