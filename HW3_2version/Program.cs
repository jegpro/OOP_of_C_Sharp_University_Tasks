using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3_2version
{
    class Program
    {
        static void Main(string[] args)
        {
            Commodity[] com = new Commodity[6];
            com[0] = new Product("Milk 2,5%", 0.99f, new DateTime(2021, 3, 3), new DateTime(2021, 3, 8)) ;
            com[1] = new Product("Sour Cream 5% ", 0.89f, new DateTime(2021, 3, 5), new DateTime(2021, 3, 15));
            com[2] = new Lot("KitKat", 0.69f, 15, new DateTime(2021, 3, 10), new DateTime(2022, 3, 25));
            com[3] = new Lot("Activia", 0.79f, 8, new DateTime(2021, 3, 1), new DateTime(2021, 3, 9));
            com[4] = new Set("Pencils", 5.99f, "Colorful");
            com[5] = new Set("Pens", 1.29f, "Black");
            
            foreach (Commodity elem in com)
                elem.Show();
            Console.WriteLine();

            Console.Write("Search -> Input expire date : ");

            DateTime n = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < 6; i++)
            {
                com[i].Search(n);
            }
            Console.ReadKey();
        }

        abstract class Commodity
        {
            protected DateTime dateNow = DateTime.Now;
            abstract public void Show();
            public void Search(DateTime n)
            {
                if (n < dateNow)
                {
                    this.Show();
                }
            }
        }
        class Product : Commodity
        {
            protected string name;
            protected float price;
            protected DateTime releaseDate;
            protected DateTime expireDate;
            public Product(string name, float price, DateTime releaseDate, DateTime expireDate)
            {
                this.name = name;
                this.price = price;
                this.releaseDate = releaseDate;
                this.expireDate = expireDate;

            }
            public override void Show()
            {
                Console.WriteLine("Commodity name - {0,15} || Price - {1,6} || Release date - {2} || Expire date - {3}", name , price, releaseDate.ToShortDateString(), expireDate.ToShortDateString());
            }

        }
        class Lot : Commodity
        {
            protected string name;
            protected float price;
            protected int count;
            protected DateTime releaseDate;
            protected DateTime expireDate;
            public Lot(string name, float price, int count, DateTime releaseDate, DateTime expireDate)
            {
                this.name = name;
                this.price = price;
                this.count = count;
                this.releaseDate = releaseDate;
                this.expireDate = expireDate;

            }
            public override void Show()
            {
                Console.WriteLine("Lot name - {0,10} || Price - {1} || Count - {2,3} || Release date - {3} || Expire date - {4}", name, price, count, releaseDate.ToShortDateString(), expireDate.ToShortDateString());
            }

        }
        class Set : Commodity
        {
            protected string name;
            protected float price;
            protected string listOfGoods;
            public Set(string name, float price, string listOfGoods)
            {
                this.name = name;
                this.price = price;
                this.listOfGoods = listOfGoods;
            }
            public override void Show()
            {
                Console.WriteLine("Name of set - {0,7} || Price - {1} || List of set - {2} ", name, price, listOfGoods);
            }

        }

    }
}
