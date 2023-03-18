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
        
        while ( DateTime.Now< futureTime)
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
 
        Console.Write(" ");
    } 
 
    public void displayCountDown(string nameOfThing, int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {            
            Console.Write(string.Format($"{nameOfThing}: {i}"));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void SetDuration(int duration = 30)
    {
        _duration = duration;
    }

    public void PrintStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine(_description);
    }

    public void PrintEndMessage()
    {
        Console.WriteLine($"Good Job completing the {_activityName} Activity");
        Thread.Sleep(1000);
        Console.WriteLine($"You just competed the {_activityName} activity for {_duration} seconds.");
    }
}
