//Write a program in C# to calculate area of triangle, square and rectangle. Write 3 different functions for each shape to take dimensions of figure and display the area. You may create menus.

    static void TriangleArea()
{
    Console.WriteLine("enter the base length of the triangle: ");
    double baseLength = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("enter the height length of the triangle: ");
    double heightLength = Convert.ToDouble(Console.ReadLine());
    double area = 0.5 * baseLength * heightLength;
    Console.WriteLine($"The area of the triangle is: {area}");
}

    static void RectangleArea()
{
    Console.WriteLine("enter the length of the rectangle: ");
    double Length = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("enter the width of the rectangle: ");
    double Width = Convert.ToDouble(Console.ReadLine());
    double area = Length * Width;
    Console.WriteLine($"The area of the rectangle is: {area}");
}

        static void SquareArea()
{
    Console.WriteLine("enter the length of the square: ");
    double Length = Convert.ToDouble(Console.ReadLine());
    double area = Length * Length;
    Console.WriteLine($"The area of the square is: {area}");
}
do
{

    Console.WriteLine("Welcome to area calculator!");
            Console.WriteLine("Please select the shape you would like to calculate the area of");
            Console.WriteLine("S: Square");
            Console.WriteLine("T: Triangle");
            Console.WriteLine("R: Rectangle");

            switch (Console.ReadLine())
            {
                case "S":
                    SquareArea();
                    break;

                case "R":
                    RectangleArea();
                    break;

                case "T":
                    TriangleArea();
                    break;

                default:
                    Console.WriteLine("Sorry that is not an option (calculator is case sensitive)");
                    break;
            }
Console.WriteLine("Would you like to continue computing? (Y = Yes please!, N = No, thank you!): ");
} while (Console.ReadLine() == "y") ;

Console.WriteLine("Thank you, come again!");
