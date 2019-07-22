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
        public double Area()
        {
            return (length * breadth);
        }
    }
}