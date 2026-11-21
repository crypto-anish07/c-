using System;

class Program
{
    static bool IsBalanced(int[] arr)
    {
        if (arr.Length % 2 == 0)
            return false;

        int middle = arr.Length / 2;
        int leftSum = 0, rightSum = 0;

        for (int i = 0; i < middle; i++)
            leftSum += arr[i];

        for (int i = middle + 1; i < arr.Length; i++)
            rightSum += arr[i];

        return leftSum == rightSum;
    }

    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element [" + i + "] : ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        if (IsBalanced(arr))
            Console.WriteLine("The array is Balanced.");
        else
            Console.WriteLine("The array is Not Balanced.");
    }
}