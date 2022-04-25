using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1._1
{
    class Book
    {
        string name;
        string author;
        int year;
        string publisher;
        int pages;


        public Book(string name, string author, int year, string publisher, int pages)
        {
            this.name = name;
            this.author = author;
            this.Year = year; //set used (Year)

            //if (year >= 0)
            //{
            //    this.year = year;
            //}
            //else
            //{
            //    Console.WriteLine(">>>>>Year must not be negative<<<<<");
            //}

            this.publisher = publisher;
            this.Pages = pages; //set used (Pages)

            //if (pages > 0)
            //{
            //    this.pages = pages;
            //}
            //else 
            //{ 
            //    Console.WriteLine(">>>>>Pages must not be negative or 0<<<<<");
            //}

        }

        public Book()
        {
            name = "undefined";
            author = "undefined";
            year = 0;
            publisher = "undefined";
            pages = 0;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 0)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine(">>>>>Year must not be negative<<<<<");
                }
            }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int Pages
        {
            get { return pages; }
            set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    Console.WriteLine(">>>>>Pages must not be negative or 0<<<<<");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} : {1, 2} | {2} : {3, 2} | {4} : {5, 2} | {6} : {7, 2}", nameof(name), name,
                nameof(year), year, nameof(author), author, nameof(pages), pages);
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Book temp = (Book)obj;
            //return this.GetHashCode().Equals(temp.GetHashCode());
            return this.author == temp.author && this.name == temp.name && this.publisher == temp.publisher &&
                this.year == temp.year && this.pages == temp.pages;
        }
    }
}
