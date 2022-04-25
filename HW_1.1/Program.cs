using System;

namespace HW_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Books which inputed :");
            Book book1 = new Book("Spider-Man", "Studio Marvel", 2020, "Thomas D.P.", 255);
            Book book2 = new Book("Hulk", "Studio Marvel", 2012, "Tom R.R.", 75);
            Book book3 = new Book();
            Console.WriteLine(book1);
            /*book2.Pages = 555;*/ //По заданию на сколько понял set не предусматривалось, но попробывал. Можно закомментировать
                                   //тогда кол-во страниц книги будет выдаваться то, которое указали при создание объекта.
                                   //book2.Author = "Johny Depp";
            Console.WriteLine(book2);
            Console.WriteLine(book3);
            book3.Name = "BATMAN";
            book3.Author = "MARVEL STUDIO";
            book3.Year = 1997;
            book3.Publisher = "Stan Lee";
            book3.Pages = 888;
            Console.WriteLine(book3);
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////

            Console.WriteLine("Book name and count in library :");
            LibraryCard card1 = new LibraryCard(book1, 10); //добавляет 10 книг Spider-Man
            LibraryCard card2 = new LibraryCard(book2, 5); //добавиляет 5 книг Hulk
            LibraryCard card3 = new LibraryCard(book1, 15); //добавляет 15 книг Spider-Man
            LibraryCard card4 = new LibraryCard(book3, 25);
            Console.WriteLine(card1); //вывод кол-ва книг Spider-Man
            Console.WriteLine(card2); // -//- Hulk
            Console.WriteLine(card3); // -//- Spider-Man
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////

            Console.WriteLine("Book returned or added book count :");
            card1.AddBook(); //указывает на возврат книги (т.е +1 книга по кол-ву)
            card2.AddBook(10); //add (просто добавляет кол-во книг заданое в скобках)
            card3.AddBook(5); //add (-//-)
            card4.AddBook();
            Console.WriteLine();
            Console.WriteLine("Book {0} count is {1}", book2.Name, card2.CountOfBook);
            Console.WriteLine("Book {0} count is {1}", book1.Name, card1.CountOfBook);
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////

            card1.BookInfo(); //Информация о книге, которую вернули или добавили ее кол-во.
            Console.WriteLine();
            card2.BookInfo();
            Console.WriteLine();
            card3.BookInfo();
            Console.WriteLine();
            card4.BookInfo();
            Console.WriteLine();






            //Equals и HashCode не делал т.к не успели на прошлом уроке и вы сказали что на  след. разберем их.
            //сам не понял, для чего данные функкции
            Console.ReadKey();
        }
    }
}
