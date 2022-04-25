using System;

namespace UsingComposition
{
    class Date
    {
        DateTime date;

        public Date(int month, int day, int year)
        {
            try
            {
                date = new DateTime(year, month, day);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                
            }
        }


        public override string ToString()  {
            //return date.ToLongDateString();
            return date.ToShortDateString();
        }
    }
}
