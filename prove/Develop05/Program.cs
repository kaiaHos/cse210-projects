using System;

class Program
{
    List<Goal> _goals = new List<Goal>();
    private int _points;
    static void Main(string[] args)
    {
        SimpleGoal simple = new SimpleGoal("say one talk", "speak in sacrament", 50);

        Console.WriteLine(simple.Completed());
        Console.WriteLine("Hello Develop05 World!");
    }

    public void SetPoints(int numPoints)
    {
        _points += numPoints;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
}