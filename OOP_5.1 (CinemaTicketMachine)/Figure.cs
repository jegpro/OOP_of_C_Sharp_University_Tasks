using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._04_Figure
{
     abstract class Figure
    {
        protected double length;
        protected double width;

        public Figure(double length,double width)
        {

            if(length>0 && width>0)
            {
                this.length = length;
                this.width = width;
            }
        }

        public double Lenght
        { get { return this.length; } }

        public double Width
        { get { return this.width; } }

        public Figure()
        {

        }
        public override string ToString()
        {
            return String.Format("Lenght = {0,3} , Width = {1,3}",length,width);
        }

        public abstract double Area();
        

        

    }
    
}
