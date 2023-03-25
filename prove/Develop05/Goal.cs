


public class Goal
{
    protected string _goal = "";
    protected string _description = "";
    protected int _completionPoints;
    private Boolean _complete = false;

    public Goal(string goalPlan, string description, int points)
    {
        _goal = goalPlan;
        _description = description;
        _completionPoints = points;
    }

        public void SetGoalCompletion(Boolean done)
    {
        _complete = done;  
    }


    public string GetGoal()
    {
        return _goal;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoint()
    {
        return _completionPoints.ToString();
    }

    public virtual string GetTimeDone()
    {
        return "";
    }

    public virtual string GetTimesToComplete()
    {
       return "";
    }

    public virtual string GetBonusPoint()
    {
        return "";
    }

    public virtual void MarkComplete(Boolean done)
    {
        Program program = new Program();
        program.SetPoints(_completionPoints); 

        SetGoalCompletion(done);
    }

    public virtual Boolean GetCompleted()
    {
        return _complete;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"Goal: {_goal} ({_description})");
    }
}