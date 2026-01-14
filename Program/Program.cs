namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            double maxArea = double.MinValue;
            string maxAreaShapeName = "";
            Shape[] shapes =
            {
                new Circle(5),
                new Rectangle(5, 2.5),
                new Triangle(17, 20, 20),
                new Circle(6.5),
                new Rectangle(20, 9)
            };
            Console.WriteLine("=== Information about shapes ===\n");
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                if (shape.CalculateArea() > maxArea)
                {
                    maxArea = shape.CalculateArea();
                    maxAreaShapeName = shape.GetType().Name;
                }
            }
            Console.WriteLine($"Max Area of all the shapes: {maxAreaShapeName} {maxArea} cm2");
        }
    }
}