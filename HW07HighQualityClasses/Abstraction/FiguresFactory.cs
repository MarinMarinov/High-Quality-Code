namespace Abstraction
{
    using System;
    
    public class FiguresFactory
    {
        public static void Main()
        {
            Circle circle = new Circle(5);
            var circlePerimeter = circle.CalculatePerimeter();
            var circleArea = circle.CalculateArea();

            Console.WriteLine("I am a circle. " + "My perimeter is {0:f2}. My area is {1:f2}.", circlePerimeter, circleArea);

            Rectangle rectangle = new Rectangle(2, 3);
            var rectanglePerimeter = rectangle.CalculatePerimeter();
            var rectangleArea = rectangle.CalculateArea();

            Console.WriteLine("I am a rectangle. " + "My perimeter is {0:f2}. My area is {1:f2}.", rectanglePerimeter, rectangleArea);
        }
    }
}