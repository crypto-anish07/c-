using System;

namespace ConsoleApp1
{
    class GenericBox<T>
    {
        // Generic field
        private T item;

        // Generic constructor
        public GenericBox(T value)
        {
            item = value;
        }

        // Generic property
        public T Item
        {
            get { return item; }
            set { item = value; }
        }

        // Generic method
        public void Display()
        {
            Console.WriteLine("Item = " + item);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericBox<int> intBox = new GenericBox<int>(100);
            intBox.Display();

            GenericBox<string> stringBox = new GenericBox<string>("This is demonstration of  Generic Class");
            stringBox.Display();

        }
    }
}