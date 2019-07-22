namespace CalucateArea
{
    public class Triangle:IShape
    {
        double height, _base;
        public Triangle(double height, double _base)
        {
            this.height = height;
            this._base = _base;
        }
             public double Area()
            {
                return (height * _base * 0.5);
            }
        
    }
}