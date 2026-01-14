namespace Program
{
    public class Rectangle : Shape
    {
        protected double Length;
        protected double Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double CalculateArea()
        {
            return Length * Width;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Shape: Rectangle\nArea: {CalculateArea()} cm2\nPerimeter: {CalculatePerimeter()} cm\n");
        }
    }
}
