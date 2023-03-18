using System;

class Program
{
    static void Main(string[] args)
    {
        string number = "";

        do
        {
            Console.Clear();
            // menu selection
            Console.WriteLine("1. Breathing"); // 1 Breathing Activity
            Console.WriteLine("2. Listing"); // 2 Listing Activity
            Console.WriteLine("3. Reflection");// 3 Reflection Activity
            Console.WriteLine("4. Quit");// 4 Quit
            Console.Write("Please enter the number of the one you want to do: ");
            number = Console.ReadLine();

            switch(number)
            {
                default: 
                    Console.WriteLine("Please enter a integer between 1 and 4 (ex. 2)");  
                    Thread.Sleep(1000); 
                    break;
                case "1": //Breathing
                    Console.Write("Would you like to set the amount of time to breathe in and out? (yes/no) ");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        Console.Write("How do you want to breathe in for in seconds? (ex.2): ");
                        int timeIn = int.Parse(Console.ReadLine());
                        Console.Write("How long do you want to breath out for in seconds? (ex. 2): ");
                        int timeOut = int.Parse(Console.ReadLine());
                        BreathingActivity breathe = new BreathingActivity(timeOut, timeIn);
                        breathe.BreathingInstruction();
                    }
                    else
                    {
                        BreathingActivity breathe = new BreathingActivity();
                        breathe.BreathingInstruction();
                    }
                    break;
                case "2": //Listing

                    break;
                case "3": // Reflection

                    break;
                case "4": // Quit
                    Console.WriteLine("Thanks for working on your Mindfulness today!");
                    break;
            }
        } while(number != "4");
        //Console.WriteLine("Hello Develop04 World!");
    }
}