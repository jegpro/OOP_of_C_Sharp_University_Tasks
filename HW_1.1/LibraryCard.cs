using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1._1
{
    class LibraryCard
    {
        Book book;
        private int countOfBook;

        public LibraryCard(Book book, int countOfBook)
        {
            this.book = book;

            if (countOfBook >= 0)
            {
                this.countOfBook = countOfBook;
            }
            else
            {
                Console.WriteLine(">>>>>Count must not be negative<<<<<");
            }
        }

        public LibraryCard()
        {
            countOfBook = 0; 
        }

        public Book Book
        {
            get { return book; }
        }

        public void BookInfo()
        {
            Console.WriteLine("Information about book :\n {0}", book);
        }

        public void AddBook()
        {
            this.countOfBook++;
            Console.WriteLine("Book \"{0}\" returned", Book.Name);
        }

        public void AddBook(int count)
        {
            this.countOfBook += count;
            Console.WriteLine("Book \"{0}\" added", Book.Name);
        }

        public int CountOfBook
        {
            get { return countOfBook; }
        }


        public override string ToString()
        {
            return string.Format("{0} : {1, 2} | {2} : {3, 2} | {4} : {5, 2}", nameof(book.Name), book.Name,
                nameof(book.Author), book.Author, nameof(countOfBook), countOfBook);
        }

        public override bool Equals(object obj)
        {
            LibraryCard temp = (LibraryCard)obj;
            return this.book.Equals(temp.book);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(book, countOfBook, Book, CountOfBook);
        }
    }
}
