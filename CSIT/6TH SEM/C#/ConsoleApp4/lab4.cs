using System;

class Person
{
    protected string name;

    // Base class constructor
    public Person(string n)
    {
        name = n;
        Console.WriteLine("Base Class Constructor Called");
    }

    // Base class method
    public void DisplayName()
    {
        Console.WriteLine("Myself " + name + " from Base Class");
    }
}

class Student : Person
{
    // Derived class constructor
    public Student(string n) : base(n)
    {
    }

    // Derived class method
    public void Show()
    {
        Console.WriteLine("Derived Class Constructor Called");
        Console.WriteLine("Name from derived class: " + base.name);
        base.DisplayName();
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Anish");
        s.Show();
    }
}