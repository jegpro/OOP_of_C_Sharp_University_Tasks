using System;
using System.Collections;


namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IF EXPIRE DATE < {0} THAT PRODUCT IS EXPIRED!\n", DateTime.Now.ToShortDateString());

            DateTime releaseData1 = new DateTime(2021, 3, 15);
            DateTime expireData1 = new DateTime(2021, 4, 15);


            DateTime releaseData2 = new DateTime(2021, 3, 12);
            DateTime expireData2 = new DateTime(2021, 3, 18);


            DateTime releaseData3 = new DateTime(2021, 3, 19);
            DateTime expireData3 = new DateTime(2021, 3, 1);


            Tovar tovar1 = new Lot("Milk 2,5%", 0.99f, 15, releaseData1, expireData1);
            Tovar tovar2 = new Lot("Steak", 15.25f, 8, releaseData2, expireData2);
            Tovar tovar3 = new Lot("Snack Balls", 2.49f, 3, releaseData3, expireData3);

            //Lot tovar1 = new Lot("Milk 2,5%", 0.99f, 15, releaseData1, expireData1);
            //Lot tovar2 = new Lot("Steak", 15.25f, 8, releaseData2, expireData2);
            //Lot tovar3 = new Lot("Snack Balls", 2.49f, 3, releaseData3, expireData3);



            ArrayList tovar = new ArrayList();
            tovar.Add(tovar1);
            tovar.Add(tovar2);
            tovar.Add(tovar3);

            foreach (object tvr in tovar)
            {
                    Console.WriteLine(tvr);
                    Console.WriteLine();
            }


            tovar1.InfoAboutProduct();
            tovar2.InfoAboutProduct();
            tovar3.InfoAboutProduct();

            //tovar1.ExpireDataChecker();
            //tovar2.ExpireDataChecker();
            //tovar3.ExpireDataChecker();


            Console.ReadKey();
        }
    }

    #region класс Товары
    abstract class Tovar
    {
        protected string name;

        public Tovar(string name)
        {
            this.name = name;
        }

        public Tovar()
        {
        }


        public void InfoAboutProduct()
        {
            Console.WriteLine("Product name : {0}", name);
        }
    }
    #endregion

    #region класс Продукты
    class Product : Tovar
    {
        protected float price;
        protected DateTime releaseData;
        protected DateTime expireData;

        public Product(string name, float price, DateTime releaseData, DateTime expireData) : base(name)
        {

            this.price = price;
            this.releaseData = releaseData;
            this.expireData = expireData;
        }
    }
    #endregion

    #region класс Партия
    class Lot : Product
    {
        protected int count;
        DateTime dateNow = DateTime.Now;

        public Lot(string name, float price, int count, DateTime releaseData, DateTime expireData) : base(name, price, releaseData, expireData)
        {
            this.count = count;
        }


        public void ExpireDataChecker()
        {
            if (DateTime.Now <= expireData)
            {
                Console.WriteLine("Product - {0} is not expired!", name);
            }
            if (DateTime.Now < releaseData)
            {
                Console.WriteLine("ERROR (Release Date cannot be higher than date now...)");
            }
            if (DateTime.Now > expireData)
            {
                Console.WriteLine("Product {0} with count {1} is EXPIRED!", name);

            }
        }
//!!!!!!!!
        public override string ToString()
        {
            return String.Format("Information about products (today {5}) : \n Name of product - {0}\n Price - {1} EUR\n Count of product : {2}\n Relese Date - {3}\n Expire Date - {4}\n", name, price, count, releaseData.ToShortDateString(), expireData.ToShortDateString(), dateNow.ToShortDateString());
        }
		
		/*
		
		List<int> numbers = new List<int>()
		ArrayList list = new ArrayList();
		int[] myArr = new int[5];
		public override bool Equals(Object obj)
		public override int GetHashCode()
		
		*/
    }
    #endregion

}


