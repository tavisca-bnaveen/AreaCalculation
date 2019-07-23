using System;

namespace CalucateArea
{
    class Program
    {
        static void Main(string[] args)
        {

            Square square = new Square(5);
            Rectangle rectangle = new Rectangle(4, 5);
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(4,5);
            Console.WriteLine(circle.CalucateArea());
            Console.ReadKey();
        }
    }
}
