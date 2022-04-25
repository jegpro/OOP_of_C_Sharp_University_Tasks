using System;
using System.Collections.Generic;
using System.Text;


namespace HW_2._1
{
    class Program
    {
        static void Main(string[] args) 
        {
            #region 1-ый вариант
            //RectangleArray rectArray = new RectangleArray();
            //Rectangle rect = new Rectangle();

            //rectArray.RectangleAdd();
            //rectArray.DrawRectangleArray();
            #endregion

            #region 2-ой вариант
            int x = 2;
            RectangleArray rectArray = new RectangleArray();
            for (int i = 3; i < 9; i += i)
            {
                x += x;
                Rectangle rectatngle = new Rectangle(x, i);
                rectArray.RectangleAdd(rectatngle);
            }
            rectArray.DrawRectangleArray();

            RectangleArray rectArray1 = new RectangleArray();
            for (int i = 0; i < 3; i++)
            {
                rectArray1.RectangleAdd();
            }
            rectArray1.DrawRectangleArray();
            #endregion
        }
    }
}
