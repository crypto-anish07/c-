
using System;

// Step 1: Create a custom exception class
class InvalidSubjectException : Exception
{
    public InvalidSubjectException(string message) : base(message)
    {

    }
}

class Program
{
    static void CheckSubject(string subject)
    {
        if (subject != "C#")
        {
            throw new InvalidSubjectException("Invalid subject entered! Only 'C#' is accepted.");
        }
        else
        {
            Console.WriteLine("Valid subject entered: " + subject);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter subject name: ");
        string subject = Console.ReadLine();

        try
        {
            CheckSubject(subject);
        }
        catch (InvalidSubjectException ex)
        {
            Console.WriteLine("Custom Exception Caught: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}