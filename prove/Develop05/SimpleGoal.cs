


public class SimpleGoal : Goal
{
    public SimpleGoal(string goal_plan, string description, int points): base(goal_plan, description, points)
    {

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
               
        Console.WriteLine($"{done} {_goal} ({_description})");
    }
}