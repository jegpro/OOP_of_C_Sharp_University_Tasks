using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1
{
     class Card
    {
        private string nameOfBook;
        private string nameOfAuthor;
        private int countOfBook;

        public Card(string nameOfBook, string nameOfAuthor, int countOfBook)
        {
            this.nameOfBook = nameOfBook;
            this.nameOfAuthor = nameOfAuthor;
            if (countOfBook >= 0)
            {
                this.countOfBook = countOfBook;
            }
            else { Console.WriteLine(">>>>>Count must not be negative<<<<<");  /*this.countOfBook = 555;*/ }
        }

        public Card()
        {
            nameOfBook = "None";
            nameOfAuthor = "None";
            countOfBook = 0;
        }

        public  string NameOfBook
        {
            get { return nameOfBook; }
            set { nameOfBook = value; }
        }

        public  string NameOfAuthor
        {
            get { return nameOfAuthor; }
            set { nameOfAuthor = value; }
        }

        public  int CountOfBook
        {
            set
            {
                if(value >= 0)
                {
                    countOfBook = value;
                }
                else { }
            }
            get { return countOfBook; }
        }

        public  void Draw()
        {
            Console.WriteLine("Information about book :\nBook name : {0,3}\nAuthor name : {1,3}\nBook count : {2,3}\n",
                nameOfBook, nameOfAuthor, countOfBook);
        }

        public override string ToString()
        {
            return String.Format("{0} : {1,3}\n{2} : {3,3}\n{4} : {5,3}",
                nameof(nameOfBook), nameOfBook, nameof(nameOfAuthor), nameOfAuthor,
                nameof(countOfBook), countOfBook);
        }
    }
}
