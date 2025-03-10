namespace HomeWork6;

class Program
{
    static void Main(string[] args)
    {
        // Answer Q1 and Q2

        // Create 2 New Professors
        Professor prof1 = new Professor { profName = "Alice", classTeach = "Java" };
        prof1.SetSalary(9000);
        Professor prof2 = new Professor { profName = "Bob", classTeach = "Math" };
        prof2.SetSalary(8000);

        // Create 2 New Students
        Student student1 = new Student { studentName = "Lisa", classEnroll = "Java" };
        student1.SetGrade(90);
        Student student2 = new Student { studentName = "Tom", classEnroll = "Math" };
        student2.SetGrade(80);

        // Answer Q2: Printing and Calculating Results

        // Print Professor details
        Console.WriteLine($"Professor {prof1.profName} teaches {prof1.classTeach}, and salary is: {prof1.GetSalary()}");
        Console.WriteLine($"Professor {prof2.profName} teaches {prof2.classTeach}, and the salary is: {prof2.GetSalary()}");

        // Print Student details
        Console.WriteLine($"Student {student1.studentName} enrolls {student1.classEnroll}, and the grade is: {student1.GetGrade()}");
        Console.WriteLine($"Student {student2.studentName} enrolls {student2.classEnroll}, and the grade is: {student2.GetGrade()}");

        // Calculate and print the difference in salary between the two professors
        double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
        Console.WriteLine($"The salary difference between Alice and Bob is: {salaryDifference}");

        // Calculate and print the total grade of Lisa’s Java course and Tom’s Math course
        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine($"The total grade of Lisa and Tom is: {totalGrade}");
    }
}

class Professor
{
    // Public properties
    public string profName { get; set; }
    public string classTeach { get; set; }

    // Private attribute with property methods
    private double salary;

    // Methods to set and get salary
    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }
}

class Student
{
    // Public properties
    public string studentName { get; set; }
    public string classEnroll { get; set; }

    // Private attribute with property methods
    private double studentGrade;

    // Methods to set and get grade
    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}


