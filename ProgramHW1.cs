namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        // Given values
        double X = 2.5;
        double Y = 3.3;

        // Calculate Z using the formula Z = 4*X*X + 3Y
        double Z = 4*X*X+3*Y;

        // Print the result in the specified format
        Console.WriteLine($"The vaule of Z when X = {X} and Y = {Y} is {Z}");

    }
}
