namespace CalucateArea
{
    public class Circle : IShape
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area()
        {
            return radius * radius * 22/7;
        }
    }
}