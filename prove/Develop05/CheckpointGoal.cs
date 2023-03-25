


public class CheckpointGoal : Goal
{
    public int _timesDone;
    public int _timesToComplete;
    public int _bonusPoints;

    public CheckpointGoal(string goal_plan, string description, int points): base(goal_plan, description, points)
    {
        _timesDone = 0;

        Console.Write("How many times to Complete: ");
        _timesToComplete = int.Parse(Console.ReadLine());

        Console.Write("How many bonus point for Completing: ");
        _bonusPoints = int.Parse(Console.ReadLine());

    }

    public void SetTimeDone(int timesDone)
    {
        _timesDone = timesDone;
    }

    public void SetTimesToComplete(int CompleteTimes)
    {
        _timesToComplete = CompleteTimes;
    }

    public void SetBonusPoint(int bonus)
    {
        _bonusPoints = bonus;
    }
    public override Boolean Completed()
    {

        return base.Completed();
    }

    public override void DisplayGoal()
    {
        string done = " ";

        if (Completed())
        {
            done = "X";
        }
               
        Console.WriteLine("{" + done + "} " + $"{_goal} ({_description} -- Currently Completed {_timesDone}/{_timesToComplete})");
    }
}