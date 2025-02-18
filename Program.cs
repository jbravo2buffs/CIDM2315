namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Q1_method()
            int largest = Q1_method(3, 5);
            Console.WriteLine($"The largest number is: {largest}");

            // Call Q2_method()
            Q2_method(5, "left");
            Q2_method(5, "right");
        }

        // Q1_method
        static int Q1_method(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // Q2_method
        static void Q2_method(int N, string shape)
        {
            Console.WriteLine($"N is: {N} shape is {shape}");
            if (shape == "left")
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(new string('*', i));
                }
            }
            else if (shape == "right")
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(new string(' ', N - i) + new string('*', i));
                }
            }
        }
    }
}