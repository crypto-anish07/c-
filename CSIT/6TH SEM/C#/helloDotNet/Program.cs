using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number between 1 and 10:");
            string? input = Console.ReadLine();
            int number = ParseNumber(input);
            Console.WriteLine($"You entered: {number}");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block executed. Cleaning up resources.");
        }
    }

    static int ParseNumber(string? input)
    {
        if (input is null)
        {
            throw new ArgumentNullException(nameof(input), "Input cannot be null.");
        }

        if (!int.TryParse(input, out int result))
        {
            throw new FormatException("Input must be a valid integer.");
        }

        if (result < 1 || result > 10)
        {
            throw new ArgumentOutOfRangeException(nameof(input), "Number must be between 1 and 10.");
        }

        return result;
    }
}