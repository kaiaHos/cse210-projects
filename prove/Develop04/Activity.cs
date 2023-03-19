using System;


public class Activity
{
    private string _activityName = "";
    private string _description = "";
    private int _duration; // in seconds

   public Activity(string description, string activity)
    {
        _activityName = activity;
        _description = description;
    }
   
    public void displaySpinner(int numSecondsToRun)
    {
        int spinnerCount = 0;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(numSecondsToRun);
        
        while (DateTime.Now < futureTime)
        {
            spinnerCount++;        
            switch (spinnerCount % 4)
            {
                case 0: 
                    Console.Write("/"); 
                    break;
                case 1: 
                    Console.Write("-"); 
                    break;
                case 2: 
                    Console.Write("\\"); 
                    break;
                case 3: 
                    Console.Write("|"); 
                    break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
 
        Console.WriteLine(" ");
    } 
 
    public void displayCountDown(string nameOfThing, int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {            
            Console.Write(string.Format($"{nameOfThing}{i}"));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
        Console.Write($"{nameOfThing}    ");
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void PrintStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        displaySpinner(1);
        Console.WriteLine(_description);
        displaySpinner(2);
        Console.Write("How long would you like your session to be in seconds? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready...");
        displaySpinner(5);
    }

    public void PrintEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Good Job completing the {_activityName} Activity");
        displaySpinner(3);
        Console.WriteLine($"You just completed the {_activityName} activity for {_duration} seconds.");
        displaySpinner(2);
    }
}
