using System;

interface IArea
{
    void CalculateArea();
}

interface IPaint
{
    void CalculatePaintCost();
}

class Rectangle : IArea, IPaint
{
    double length, breadth, area;

    public Rectangle(double l, double b)
    {
        length = l;
        breadth = b;
    }

    public void CalculateArea()
    {
        area = length * breadth;
        Console.WriteLine("Area of Rectangle = " + area);
    }

    public void CalculatePaintCost()
    {
        double cost = area * 20;   // Paint cost = Rs.20 per sq. unit
        Console.WriteLine("Paint Cost = Rs. " + cost);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Length: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter Breadth: ");
        double breadth = double.Parse(Console.ReadLine());

        Rectangle r = new Rectangle(length, breadth);

        r.CalculateArea();
        r.CalculatePaintCost();
    }
}