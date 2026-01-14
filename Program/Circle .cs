namespace Program
{
    public class Circle : Shape
    {
        protected double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Shape: Circle\nArea: {CalculateArea()}\nPerimeter: {CalculatePerimeter()}");
        }
    }
}
