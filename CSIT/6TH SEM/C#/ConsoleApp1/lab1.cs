using System;

class Program
{
    static void Main()
    {
        int[][] marks = new int[3][];
        int[] total = new int[3];
        double[] average = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter the number of subject for student[" + i + "] : ");
            int n = int.Parse(Console.ReadLine());

            marks[i] = new int[n];

            for (int j = 0; j < n; j++)
            {
                Console.Write("Element [" + i + "][" + j + "] : ");
                marks[i][j] = int.Parse(Console.ReadLine());

                total[i] += marks[i][j];
            }

            average[i] = (double)total[i] / n;
        }

        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("The total marks of student [" + i + "] is " + total[i]);
            Console.WriteLine("The average marks of student [" + i + "] is " + average[i]);
        }
    }
}