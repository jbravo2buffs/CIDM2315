namespace HomeWork9;

using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public string GetName()  // Added helper method to access studentName
    {
        return studentName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 2: Create 4 students
        Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Cathy");
        Student student4 = new Student(444, "David");

        // Step 3: Create gradebook dictionary and add name-grade pairs
        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8}
        };

        // Step 4: Check for Tom and add if not present
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        // Step 5: Calculate and print average GPA
        double averageGPA = gradebook.Values.Average();
        Console.WriteLine($"The average GPA is: {averageGPA}");

        // Step 6: Print students with GPA above average
        foreach (Student student in Student.studentList)
        {
            string name = student.GetName();
            if (gradebook.ContainsKey(name) && gradebook[name] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}


