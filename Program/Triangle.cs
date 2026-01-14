namespace Program
{
    public class Triangle : Shape
    {
        protected double FirstSideLength;
        protected double SecondSideLength;
        protected double ThirdSideLength;

        public Triangle(double firstSideLength, double secondSideLength, double thirdSideLength)
        {
            FirstSideLength = firstSideLength;
            SecondSideLength = secondSideLength;
            ThirdSideLength = thirdSideLength;
        }
    }
}
