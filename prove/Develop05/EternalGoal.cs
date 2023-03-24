


public class EternalGoal : Goal
{
    public EternalGoal(string goal_plan, string description, int points): base(goal_plan, description, points)
    {

    }

    public override Boolean Completed()
    {
        return false;
    }

    public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.WriteLine("{ }", $"{_goal} ({_description})");
    }
}