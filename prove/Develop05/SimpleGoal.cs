


public class SimpleGoal : Goal
{
    public SimpleGoal(string goal_plan, string description, int points): base(goal_plan, description, points)
    {

    }

    public override Boolean GetCompleted()
    {
        return base.GetCompleted();
    }

    public override void MarkComplete(Boolean done = true)
    {
        Program program = new Program();
        program.SetPoints(_completionPoints); 

        SetGoalCompletion(done);
    }

    public override void DisplayGoal()
    {
        string done = "{ }";

        if (GetCompleted())
        {
            done = "{X}";
        }
               
        Console.WriteLine($"{done} {_goal} ({_description})");
    }


}