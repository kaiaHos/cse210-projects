


public class CheckpointGoal : Goal
{
    private int _timesDone;
    private int _timesToComplete;
    private int _bonusPoints;

    public CheckpointGoal(string goal_plan, string description, int points): base(goal_plan, description, points)
    {
        
    }

    public void SetOtherInfo()
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

    public override void MarkComplete(Boolean done = true)
    {
        Program program = new Program();
        program.SetPoints(_completionPoints); 
        _timesDone += 1;

        if (_timesDone == _timesToComplete)
        {
            SetGoalCompletion(done);
            program.SetPoints(_bonusPoints);
        }
    }

     public override string GetTimeDone()
    {
        return _timesDone.ToString();
    }

    public override string GetTimesToComplete()
    {
       return _timesToComplete.ToString();
    }

    public override string GetBonusPoint()
    {
        return _bonusPoints.ToString();
    }
    public override Boolean GetCompleted()
    {

        return base.GetCompleted();
    }

    public override void DisplayGoal()
    {
        string done = " ";

        if (GetCompleted())
        {
            done = "X";
        }
               
        Console.WriteLine("{" + done + "} " + $"{_goal} ({_description} -- Currently Completed {_timesDone}/{_timesToComplete})");
    }
}