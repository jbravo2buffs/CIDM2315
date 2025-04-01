namespace HomeWork8;

class Program
{
    static void Main(string[] args)
    {
        // Creating Customer objects and customer_list
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        // Call all methods in sequence
        TotalCredits(customer_list);
        AmarilloAverageAge(customer_list);
        CanyonAge(customer_list);
    }

    // Q1: Calculate and print total credit of all customers
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = 0;
        foreach (Customer customer in customer_list)
        {
            totalCredit += customer.customerCredit;
        }
        Console.WriteLine($"Q1: The total credits: {totalCredit}");
    }

    // Q2: Calculate and print average age of Amarillo customers
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        int totalAge = 0;
        int amarilloCount = 0;

        foreach (Customer customer in customer_list)
        {
            if (customer.customerCity == "Amarillo")
            {
                totalAge += customer.customerAge;
                amarilloCount++;
            }
        }

        double averageAge = (double)totalAge / amarilloCount;
        Console.WriteLine($"Q2: The average age of customers in Amarillo: {averageAge}");
    }

    // Q3: Print names of Canyon customers over 30
    public static void CanyonAge(Customer[] customer_list)
    {
        Console.Write("Q3: Customers who live in Canyon and over 30 years old: ");
        bool firstMatch = true;

        foreach (Customer customer in customer_list)
        {
            if (customer.customerCity == "Canyon" && customer.customerAge > 30)
            {
                if (!firstMatch)
                {
                    Console.Write(", ");
                }
                Console.Write(customer.customerName);
                firstMatch = false;
            }
        }
        Console.WriteLine();
    }
}

class Customer
{
    // Q0: Customer class with properties
    public string customerName { get; set; }
    public int customerAge { get; set; }
    public string customerCity { get; set; }
    public double customerCredit { get; set; }

    // Constructor
    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}