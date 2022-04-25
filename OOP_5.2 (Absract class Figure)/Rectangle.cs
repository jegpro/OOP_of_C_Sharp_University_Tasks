using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._04_Figure
{
    class Rectangle : Figure
    {

        public override double Area()
        {
            return width * length;
        }

        public Rectangle():base(1,1)
        {

        }
        public Rectangle(double length , double width):base(length,width)
        {
            if(length>50)
            {
                this.length = 50;
            }
            if(width>50)
            {
                this.width = 50;
            }
  
        }
           

    }
}
