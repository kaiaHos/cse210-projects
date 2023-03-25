using System;

class Program
{
    static List<Goal> _goals = new List<Goal>();
    private static int _points;
   
    static void Main(string[] args)
    {
        string menuNumber;
        File file = new File();

        do
        {
            Console.WriteLine($" You have {_points} points");
            Console.WriteLine();
            Console.WriteLine("1. New Goal"); 
            Console.WriteLine("2. List Goals"); 
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record an Event");
            Console.WriteLine("6. Quit");
            Console.Write("Please enter the number of the one you want to do: ");
            menuNumber = Console.ReadLine();

            switch(menuNumber)
            {
                default: 
                    Console.WriteLine("Please enter a integer between 1 and 6 (ex. 2)");  
                    Thread.Sleep(1000); 
                    break;
                case "1": //new Goal
                    Console.WriteLine("1. Simple"); // 1 Breathing Activity
                    Console.WriteLine("2. Eternal"); // 2 Listing Activity
                    Console.WriteLine("3. Checkpoint");// 3 Reflection Activity

                    Console.Write("Please enter the number of the one you want to do: ");
                    string goalType = Console.ReadLine();

                    Console.Write("What is the Goal: ");
                    string goalPlan = Console.ReadLine();

                    Console.Write("What is the description of the goal: ");
                    string description = Console.ReadLine();

                    Console.Write("How many points do you earn for completing: ");
                    int points = int.Parse(Console.ReadLine());

                    switch (goalType)
                    {
                        case "1": // simple
                            SimpleGoal sim = new SimpleGoal(goalPlan, description, points);
                            _goals.Add(sim);
                            break; 
                        case "2":// eternal
                            EternalGoal etern = new EternalGoal(goalPlan, description, points);
                            _goals.Add(etern);
                            break;
                        case "3":  // checkpoint
                            CheckpointGoal check = new CheckpointGoal(goalPlan, description, points);
                            _goals.Add(check);
                            break;
                    }
                    break; 
                case "2": // list Goal
                    foreach (Goal goal in _goals)
                    {
                        goal.DisplayGoal();
                    }
                    break;
                case "3": // Save Goal
                    foreach (Goal oldGoal in _goals)
                    {
                        file.SaveGoal(oldGoal);
                    }
                    break;
                case "4": // Load Goals
                    file.LoadGoals();
                    break;
                case "5": // Record Event
                    break;
                case "6": // Quit
                    Console.WriteLine("Thanks for Goal setting/completing today!");
                    break;
       
            }
        } while (menuNumber != "6");
        //SimpleGoal simple = new SimpleGoal("say one talk", "speak in sacrament", 50);
        //Console.WriteLine(simple.Completed());

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