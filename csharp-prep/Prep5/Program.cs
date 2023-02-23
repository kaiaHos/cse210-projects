using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(squaredNumber, name);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the the squaring program!");
    }
    static string PromptUserName()
    {
        string userName;
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        int userNumber;
        Console.Write("Please enter your favorite number: ");
        userNumber = int.Parse(Console.ReadLine());
        return userNumber;

    }
    static int SquareNumber(int numberToSquare)
    {
        int numberSquared = numberToSquare * numberToSquare;
        return numberSquared;
    }
    static void DisplayResult(int squaredNumber, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}