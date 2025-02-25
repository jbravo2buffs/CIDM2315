namespace HomeWork5;

class Program

{
    static void Main(string[] args)
    {
        // Call Q1_method
        Q1_method();

        // Call Q2_method
        Q2_method();

        // Call Q3_method
        Q3_method();
    }

    // Q1: Method to find the largest of 2 integers
    static void Q1_method()
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());

        int largest = FindLargestOfTwo(a, b);
        Console.WriteLine($"The largest number is: {largest}");
    }

    static int FindLargestOfTwo(int x, int y)
    {
        return (x > y) ? x : y;
    }

    // Q2: Method to find the largest of 4 integers using Q1's method
    static void Q2_method()
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number:");
        int d = int.Parse(Console.ReadLine());

        int max1 = FindLargestOfTwo(a, b);
        int max2 = FindLargestOfTwo(c, d);
        int largest = FindLargestOfTwo(max1, max2);

        Console.WriteLine($"The largest number is: {largest}");
    }

    // Q3: Account creation process
    static void Q3_method()
    {
        createAccount();
    }

    static bool checkAge(int birth_year)
    {
        int current_year = 2025;
        int age = current_year - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string password1 = Console.ReadLine();

        Console.WriteLine("Enter password again:");
        string password2 = Console.ReadLine();

        Console.WriteLine("Enter birth year:");
        int birthyear = int.Parse(Console.ReadLine());

        if (checkAge(birthyear))
        {
            if (password1 == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}



