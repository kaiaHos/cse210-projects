using System;

class Program
{
    static void Main(string[] args)
    {
        // This gets the user input for first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // This gets the user input for the last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // THis write out the name with last, first last
        Console.Write($"YOur name is {lastName}, {firstName} {lastName}");
    }
}