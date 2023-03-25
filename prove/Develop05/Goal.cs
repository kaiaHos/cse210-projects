


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

    public virtual void SetGoalCompletion(Boolean done)
    {
        Program program = new Program();
        _complete = done;

        program.SetPoints(_completionPoints);       
    }

    public virtual Boolean Completed()
    {
        return _complete;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"Goal: {_goal} ({_description})");
    }
}