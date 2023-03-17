using System;

class Program
{
    static void Main(string[] args)
    {
        // menu selection
        Console.WriteLine("1. Breathing"); // 1 New Entry
        Console.WriteLine("2. Listing"); // 2 Display Journal
        Console.WriteLine("3. Reflection");// 3 Save Journal
        Console.WriteLine("4. Quit");// 4 Quit

        switch(int.Parse(Console.ReadLine()))
        {
            default: 
                Console.Write("In switch statement");
                
                break;
            case 1:

                break;
            case 2:

                break;
        }

        //Console.WriteLine("Hello Develop04 World!");
    }
}