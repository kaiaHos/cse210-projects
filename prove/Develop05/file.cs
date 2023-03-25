using System.IO;


class File : Program
{
    public void SaveGoal(Goal goal)
    {

        Console.WriteLine(goal);
    }

    public void LoadGoals()
    {
        Console.Write("Please enter the file name? ");
        string fileName = Console.ReadLine();
        int count = 0;
         Program program = new Program();

        string[] file = System.IO.File.ReadAllLines(fileName);

        // line in this format  date||prompt||journalEntry
        foreach (string line in file)
        {
            // this allows us to skip the header of the file.
            if (count > 0)
            {
                string[] Goalparts = line.Split(":");

                string goalInfo = Goalparts[1];
                string GoalType = Goalparts[0];

                if (GoalType == "EternalGoal")
                {
                    CreateEternalGoal(goalInfo);
                }
                else  if (GoalType == "SimpleGoal")
                {
                    CreateSimpleGoal(goalInfo);
                }
                 if (GoalType == "CheckpointGoal")
                {
                    CreateCheckpointGoal(goalInfo);
                }
            }
            else if (count == 0)
            {
                program.SetPoints(int.Parse(line)); 
                count = count + 1;
            }
        }
           
    }

    public void CreateSimpleGoal(string AllGoalInfo)
    {
        string[] parts = AllGoalInfo.Split("||");

        SimpleGoal simple = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));
        simple.SetGoalCompletion(Convert.ToBoolean(parts[4]));
        AddGoal(simple);
    }

    public void CreateEternalGoal(string AllGoalInfo)
    {
        string[] parts = AllGoalInfo.Split("||");

        EternalGoal eternal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
        AddGoal(eternal);
    }

    public void CreateCheckpointGoal(string AllGoalInfo)
    {
        string[] parts = AllGoalInfo.Split("||");

        CheckpointGoal checkpoint = new CheckpointGoal(parts[0], parts[1], int.Parse(parts[2]));

        checkpoint.SetBonusPoint(int.Parse(parts[3]));
        checkpoint.SetTimeDone(int.Parse(parts[4]));
        checkpoint.SetTimesToComplete(int.Parse(parts[5]));
        AddGoal(checkpoint);

    }


}


// source I found info on how to turn a string into a boolean
// https://code-maze.com/csharp-convert-string-to-bool/