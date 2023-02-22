using System;

class Program
{
    static void Main(string[] args)
    {
        // This gets the user input for first name
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        // This gets the user input for the last name
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        // THis write out the name with last, first last
        Console.Write($"YOur name is {last_name}, {first_name} {last_name}");
    }
}