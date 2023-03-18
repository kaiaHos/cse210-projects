


public class BreathingActivity: Activity
{
    private int _breathInTime;
    private int _breathOutIme;

    public BreathingActivity() : base("This activitiy will help you focus on your breathing to help you relax. You will do this by slowly breathing in and out for a certain number of seconds.", "Breathing")
    {
        _breathInTime = 4;
        _breathOutIme = 5;
    }

     public BreathingActivity(int outTime, int inTime) : base("This activitiy will help you focus on your breathing to help you relax. You will do this by slowly breathing in and out for a certain number of seconds.", "Breathing")
    {
        _breathInTime = inTime;
        _breathOutIme = outTime;
    }

    public void BreathingInstruction()
    {
        PrintStartMessage();
        Console.Write("How long would you like your session to be in seconds? ");
        SetDuration(int.Parse(Console.ReadLine()));

        // This where the loop with breathing code will go

        PrintEndMessage();
    }
}