using System.Security.AccessControl;

namespace Program
{
    public class Triangle : Shape
    {
        protected double FirstSideLength;
        protected double SecondSideLength;
        protected double ThirdSideLength;

        public Triangle(double firstSideLength, double secondSideLength, double thirdSideLength)
        {
            if (firstSideLength + secondSideLength < thirdSideLength || firstSideLength + thirdSideLength < secondSideLength
                || secondSideLength + thirdSideLength < firstSideLength)
            {
                throw new Exception("Triangle with such sides' length is impossible");
            }
            else
            {
                FirstSideLength = firstSideLength;
                SecondSideLength = secondSideLength;
                ThirdSideLength = thirdSideLength;
            }
        }
        public override double CalculateArea()
        {
            double semiPerimeter = CalculatePerimeter() / 2;
            return Math.Round(Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSideLength) * (semiPerimeter - SecondSideLength) *
                (semiPerimeter - ThirdSideLength)), 2);
        }
        public override double CalculatePerimeter()
        {
            return FirstSideLength + SecondSideLength + FirstSideLength;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Shape: Triangle\nArea: {CalculateArea()} cm2\nPerimeter: {CalculatePerimeter()} cm\n");
        }
    }
}
