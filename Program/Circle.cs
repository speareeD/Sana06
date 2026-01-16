namespace Program
{
    public class Circle : Shape
    {
        protected double Radius;
        public Circle(double radius)
        {
            if (radius < 1)
            {
                throw new Exception("Radius cannot be less than 1");
            }
            else
            {
                Radius = radius;
            }
        }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        public override double CalculatePerimeter()
        {
            return Math.Round(2 * Math.PI * Radius, 2);
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Shape: Circle\nArea: {CalculateArea()} cm2\nPerimeter: {CalculatePerimeter()} cm\n");
        }
    }
}
