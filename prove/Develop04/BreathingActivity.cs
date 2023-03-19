


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
        //Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        
        while (DateTime.Now < futureTime)
        {
            // This is the loop with breathing code
            Console.WriteLine("");
            displayCountDown("Breath in...", _breathInTime);
            Console.WriteLine("");
            displayCountDown("Breath out...", _breathOutIme);
            Console.WriteLine("");
        }
    
        PrintEndMessage();        
    }
}