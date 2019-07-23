using System;
namespace CalucateArea
{
    public class Triangle:IShape
    {
        double height, _base;
        public Triangle(double side)
        {
            height = Math.Sqrt(3);
            height = height / 2;
            _base = side * side;
        }
        public Triangle(double height, double _base)
        {
            this.height = height;
            this._base = _base;
        }
        public Triangle(double side1,double side2,double side3)
        {
            double s = (side1 + side2 + side3) / 2;
            height =2* Math.Sqrt(s * (s - side1));
            _base = Math.Sqrt((s - side2) * (s - side3));
         }
             public double CalucateArea()
            {
                return (height * _base * 0.5);
            }
        
    }
}