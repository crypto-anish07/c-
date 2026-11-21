using System;

class Program
{
    // Generic Delegate
    delegate T Add<T>(T a, T b);

    // Generic Method
    static T Sum<T>(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x + y;
    }

    static void Main()
    {
        // Integer Input
        Console.Write("Enter first integer: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second integer: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Add<int> intAdd = Sum;
        Console.WriteLine("Integer Addition = " + intAdd(a, b));

        // Decimal Input
        Console.Write("\nEnter first decimal: ");
        decimal x = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter second decimal: ");
        decimal y = Convert.ToDecimal(Console.ReadLine());

        Add<decimal> decimalAdd = Sum;
        Console.WriteLine("Decimal Addition = " + decimalAdd(x, y));
    }
}