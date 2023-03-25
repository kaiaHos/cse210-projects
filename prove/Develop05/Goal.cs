


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
        _complete = done;
    }

    public virtual Boolean Completed()
    {
        return _complete;
    }

    public virtual void DisplayGoal()
    {

    }
}