﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            // Add items
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);

            Console.WriteLine("After Adding items:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            // Remove an item
            numbers.Remove(20);
            Console.WriteLine("\nAfter Removing 20:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            // Check if item exists
            bool exists = numbers.Contains(30);
            Console.WriteLine("\nDoes list contain 30? " + exists);

            bool exists2 = numbers.Contains(20);
            Console.WriteLine("Does list contain 20? " + exists2);

            // Clear all items
            numbers.Clear();
            Console.WriteLine("\nAfter Clearing the list:");
            Console.WriteLine("Count of items = " + numbers.Count);
        }
    }
}