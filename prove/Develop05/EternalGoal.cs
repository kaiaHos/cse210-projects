


public class EternalGoal : Goal
{
    public EternalGoal(string goal_plan, string description, int points): base(goal_plan, description, points)
    {

    }

    public override void CompleteGoal(Boolean done = false)
    {
        Program program = new Program();
        program.SetPoints(_completionPoints); 

        SetGoalCompletion(false);
    }

    public override Boolean GetCompleted()
    {
        return false;
    }

    public override void DisplayGoal()
    {
        //base.DisplayGoal();
        Console.WriteLine("{ }" + $" {_goal} ({_description})");
    }
}