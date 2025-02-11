namespace HomeWork3;

{
    class Program
    {
        static void Main(string[] args)
        {
            // Code for Q1: Check if a number is prime
            Console.WriteLine("Enter a number for Q1:");
            int n1 = int.Parse(Console.ReadLine());
            bool isPrime = true;
            
            if (n1 <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < n1; i++)
                {
                    if (n1 % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{n1} is prime");
            }
            else
            {
                Console.WriteLine($"{n1} is non-prime");
            }

            // Code for Q2: Print square pattern
            Console.WriteLine("Enter a number for Q2:");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Code for Q3: Print diagonal pattern
            Console.WriteLine("Enter a number for Q3:");
            int n3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n3; i++)
            {
                for (int j = 0; j < n3; j++)
                {
                    if (i == j || i + j == n3 - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            // Code for Bonus question: Print cross pattern
            Console.WriteLine("Enter a number for the Bonus question:");
            int nBonus = int.Parse(Console.ReadLine());

            for (int i = 0; i < nBonus; i++)
            {
                for (int j = 0; j < nBonus; j++)
                {
                    if (i == j || i + j == nBonus - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
