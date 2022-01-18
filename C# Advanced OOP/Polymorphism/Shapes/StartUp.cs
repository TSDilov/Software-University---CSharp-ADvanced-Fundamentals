using System;

namespace Shapes

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 6);
            Circle circle = new Circle(5);

            Console.WriteLine(rectangle.Draw());
            var rectanglePerimeter = rectangle.CalculatePerimeter();
            Console.WriteLine($"{rectanglePerimeter:F2}");
            var rectangleArea = rectangle.CalculateArea();
            Console.WriteLine($"{rectangleArea:F2}");

            Console.WriteLine(circle.Draw());
            var circlePerimeter = circle.CalculatePerimeter();
            Console.WriteLine($"{circlePerimeter:F2}");
            var circleArea = circle.CalculateArea();
            Console.WriteLine($"{circleArea:F2}");
        }
    }
}
