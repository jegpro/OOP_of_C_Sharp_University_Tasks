using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2._1
{
    class RectangleArray
    {
        List<Rectangle> list;
        int lengthValue = 2;
        int widthValue = 3;

        public RectangleArray() //конструктор без параметров.
        {
            list = new List<Rectangle>(); //Конструктор создает объект класса List.
        }

        public void RectangleAdd() /*заносит данные в динамический массив. Элемент массива – объект класса Rectangle.
                                    Каждый следующий элемент массива в 2 раза больше предыдущего. */
        {
            #region 1-ый вариант
            //if (list.Count == 0) //если число является первые в списке, то без удвоения
            //{
            //    Rectangle rectangle = new Rectangle();
            //    list.Add(rectangle);
            //}
            //if (list.Count == 1) //в последующий случаях значение приобретает значение, которые вышло при удвоении
            //{
            //    Rectangle rectangle = new Rectangle();
            //    rectangle.Length *= 2;
            //    rectangle.Width *= 2;
            //    list.Add(rectangle);
            //}
            //if (list.Count == 2)
            //{
            //    Rectangle rectangle = new Rectangle();
            //    rectangle.Length *= 4;
            //    rectangle.Width *= 4;
            //    list.Add(rectangle);
            //}
            //if (list.Count == 3)
            //{
            //    Rectangle rectangle = new Rectangle();
            //    rectangle.Length *= 8;
            //    rectangle.Width *= 8;
            //    list.Add(rectangle);
            //}
            //if (list.Count == 4)
            //{
            //    Rectangle rectangle = new Rectangle();
            //    rectangle.Length *= 16;
            //    rectangle.Width *= 16;
            //    list.Add(rectangle);
            //}
            //if (list.Count == 5)
            //{
            //    Rectangle rectangle = new Rectangle();
            //    rectangle.Length *= 32;
            //    rectangle.Width *= 32;
            //    list.Add(rectangle);
            //}
            //if (list.Count == 6)
            //{
            //    Rectangle rectangle = new Rectangle();
            //    rectangle.Length *= 64;
            //    rectangle.Width *= 64;
            //    list.Add(rectangle);
            //}
            #endregion

            #region 2-ой вариант
            Rectangle rectangle = new Rectangle(lengthValue, widthValue);
            list.Add(rectangle);
            lengthValue += lengthValue;
            widthValue += widthValue;
            #endregion
        }

        public void RectangleAdd(Rectangle rectangle)
        {
            list.Add(rectangle);
        }


        public void DrawRectangleArray()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("LIST EMPTY!");
            }
            else
            {
                foreach (Rectangle rectangle in list)
                {
                    Console.WriteLine(rectangle);
                    Console.WriteLine();
                    rectangle.DrawFill();
                }
            }
            Console.WriteLine();
        }
    }


}
