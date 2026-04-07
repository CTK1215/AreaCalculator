using System.Net.Security;

namespace AreaCalculator;

class Program
{
    static void Main(string[] args)
    {

            //finding the area of a circle user input
            Console.WriteLine("Please enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of your circle is {CircleArea(radius)}");

            //Finding the area of a triangle
            Console.WriteLine("Now onto the area of your triangle, what is the base length of your triangle?");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the height of your triangle?");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of your triangle is {TriangleArea(baseLength, height)}");

            //Finding the area of a rectangle
            Console.WriteLine("You also wanted to find out the area of a rectangle, can you tell me what the length of your rectangle please?");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thank you, now tell me what the width or your rectangle is?");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of your rectangle is {RectangleArea(length, width)}");

            //Finding the area of a square
            Console.WriteLine("Alright, now we will determine the area of your square, what is the measurement of one side of your square?");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of your square is {SquareArea(side)}");

            Console.WriteLine("Thank you for participating in my project, I appreciate it and hope you have a wonderful day.");
        }

    
    
    public static double CircleArea(double radius)
    
    
    {
        //Formula for the area of a circle
        return Math.PI * radius * radius;
    }

    public static double TriangleArea(double baseLength, double height)

    {
        //Formula for area of Triangle
        return baseLength * height / 2;
    }

    public static double RectangleArea(double length, double width)

    {
        //Formula for area of Rectangle
        return length * width;
    }
    
    public static double SquareArea(double side)
    
    {
        //Formula for area of Square
        return side * side;
        
    }
}