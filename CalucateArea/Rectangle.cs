using System;

namespace CalucateArea
{
    public class Rectangle : IShape
    {
        double length, breadth;
        public Rectangle(double length,double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double CalucateArea()
        {
            return (length * breadth);
        }
    }
}