using System;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card("BlaBla", "Pushkin", 11);
            card1.Draw();
            //Console.WriteLine(card1); //override using
            //Console.WriteLine();

            Card card2 = new Card("Lev Tolstoi", "Anna Karenina", -55);
            //card2.CountOfBook = 155; //set
            card2.Draw();

            Card card3 = new Card();
            card3.NameOfBook = "Mihail Gagarin"; //set
            card3.NameOfAuthor = "Dobrinj Nikitich"; //set
            card3.CountOfBook = 155; //set
            card3.Draw();

            Console.WriteLine(card2); //override using
            Console.WriteLine(card2.CountOfBook); //calling methods sepperatly 

         
            Console.ReadKey();
        }
    }
}
