


public class BreathingActivity: Activity
{
    private int _breathInTime;
    private int _breathOutIme;

     public BreathingActivity(int outTime = 4, int inTime = 5) : base("This activitiy will help you focus on your breathing to help you relax. You will do this by slowly breathing in and out for a certain number of seconds.", "Breathing")
    {
        _breathInTime = inTime;
        _breathOutIme = outTime;
    }

    public void BreathingInstruction()
    {
        PrintStartMessage();
        Console.Write("How long would you like your session to be in seconds? ");
        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();

        // This is the loop with breathing code
        displayCountDown("Breath in...", _breathInTime);
        displayCountDown("Breath out...", _breathOutIme);

    
        PrintEndMessage();
        displaySpinner(2);
        
    }
}