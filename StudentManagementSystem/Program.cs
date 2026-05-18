using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
    public int Age;
    public string Department;

    public Student(int id, string name, int age, string department)
    {
        Id = id;
        Name = name;
        Age = age;
        Department = department;
    }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Student Management System =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ViewStudents();
                    break;
                case 3:
                    SearchStudent();
                    break;
                case 4:
                    DeleteStudent();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    Pause();
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Department: ");
        string dept = Console.ReadLine();

        students.Add(new Student(id, name, age, dept));

        Console.WriteLine("Student added successfully!");
        Pause();
    }

    static void ViewStudents()
    {
        foreach (Student s in students)
        {
            Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}, Dept: {s.Department}");
        }
        Pause();
    }

    static void SearchStudent()
    {
        Console.Write("Enter Student ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Student s in students)
        {
            if (s.Id == id)
            {
                Console.WriteLine($"Found: {s.Name}");
                Pause();
                return;
            }
        }

        Console.WriteLine("Student not found.");
        Pause();
    }

    static void DeleteStudent()
    {
        Console.Write("Enter Student ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Id == id)
            {
                students.RemoveAt(i);
                Console.WriteLine("Deleted.");
                Pause();
                return;
            }
        }

        Console.WriteLine("Not found.");
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("Press Enter...");
        Console.ReadLine();
    }
}