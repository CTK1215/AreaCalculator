namespace AreaCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
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