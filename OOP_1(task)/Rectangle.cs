using System;
namespace OOPPractice
{
    public class Rectangle
    {
        public int Length
        {
            get { return length; }
        }
        public int Width
        {
            get { return width; }
        }
        private int length;
        private int width;

        public Rectangle()
        {
            this.length = 10;
            this.width = 15;
        }
        public Rectangle(int length, int width)
        {
            if(length > 0 && width > 0)
            {
                this.length = length;
                this.width = width;
            }
            else
            {
                this.length = 10;
                this.width = 15;
            }
        }

        public int Area()
        {
            return length * width;
        }

        public void DrawFill()
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void Draw()
        {
            for (int i = 1; i <= length; i++)
            {
                if (i == 1 || i == length)
                {
                    for (int j = 1; j <= width; j++)
                    {
                        Console.Write("#");
                    }
                }
                else
                {
                    for (int j = 1; j <= width; j++)
                    {
                        if (j == 1 || j == width)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                
                }
                Console.WriteLine();
            }
        }//end Draw

        public override string ToString()
        {
            return String.Format(
                "Rectangle : {0,4} * {1,4}", Length, Width);
        }
    }
}
