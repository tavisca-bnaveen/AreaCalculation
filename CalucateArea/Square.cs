using System;

namespace CalucateArea
{
    public class Square : IShape
    {
        double side; 
       public Square(double side)
        {
            this.side = side;
        }
        public double CalucateArea()
        {
            return (side * side);
        }
    }
}