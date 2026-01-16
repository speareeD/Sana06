namespace Program
{
    public class Rectangle : Shape
    {
        protected double Length;
        protected double Width;

        public Rectangle(double length, double width)
        {
            if (length < 1)
            {
                throw new Exception("Length cannot be less than 1");
            }
            else
            {
                Length = length;
            }
            if (width < 1)
            {
                throw new Exception("Width cannot be less than 1");
            }
            else
            {
                Width = width;
            }
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
