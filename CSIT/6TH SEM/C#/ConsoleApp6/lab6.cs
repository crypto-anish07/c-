using System;

// Declare a delegate
delegate void Operation();

class Demo
{
    public void Add()
    {
        Console.WriteLine("Addition Method Called");
    }

    public void Subtract()
    {
        Console.WriteLine("Subtraction Method Called");
    }
}

class Program
{
    static void Main()
    {
        Demo obj = new Demo();

        // Delegate object
        Operation op;

        op = obj.Add;
        op();

        op = obj.Subtract;
        op();
    }
}