using System;

class Program
{
   
    static void Main(string[] args)
    {
        int selection;
        Journal myJournal = new Journal();

        do{
            // menu selection
            Console.WriteLine("1. New Entry"); // 1 New Entry
            Console.WriteLine("2. DisplayJournal"); // 2 Display Journal
            Console.WriteLine("2 Save Journal");// 3 Save Journal
            Console.WriteLine("2 Load Journal");// 4 Load Journal
            Console.WriteLine("5 Quit");// 5 Quit

            // this is how the use selects the number.
            Console.Write("Enter number: ");
            
            selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                //Journals myJournal = new Journals();
                myJournal.AddEntry();
            }
            else if (selection == 2)
            {
                myJournal.DisplayEntries();
            }
            else if (selection == 3)
            {
                myJournal.LoadFile();
            }
            else if (selection == 4)
            {
                myJournal.SaveFile();
            }
            
        } while (selection != 5);
        //Console.WriteLine("Hello Develop02 World!");
    }
    
   
}