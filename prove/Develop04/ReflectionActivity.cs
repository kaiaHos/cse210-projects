


public class ReflectionActivity: Activity
{
    
    private List<string> _prompts = new List<string>{"Think of a time you felt the Spirit", "Think of a time in which you did a random act of kindness", "Think of a time when you did something really difficult", "Think of a time when you stood up for someone else."};
    private List<string> _questions = new List<string>{"How did this event impact your perspective on life?", "How did you feel when it was complete?", "What is your favorite thing about this experience?", "Did something lead up to the experience?", "Did the experience change any of your habits?"};

    public ReflectionActivity() : base("This activity is used to help you remember certain aspects of your day or life. It will rotate through different question to help you go more indepth with your remembrance.", "Reflection")
    {

    }

    public void GetAndDisplayPrompt()
    {
        PrintStartMessage();
        
        int promptCount = _prompts.Count();
        int RandomNum = new Random().Next(0, promptCount);

        Console.WriteLine($"--- {_prompts[RandomNum]} ---");
        Console.WriteLine();
        Console.WriteLine("Once you have thought of an experience hit enter to move on.");
        Console.ReadLine();
        Console.WriteLine("Ponder the following questions and how they relate to the experience");
        displayCountDown("Begin in:", 5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < futureTime)
        {
            int questionCount = _questions.Count();
            int RandomNumber = new Random().Next(0, questionCount);
            Console.WriteLine(_questions[RandomNumber]);
            displaySpinner(10);
        }
    
        PrintEndMessage();
        displaySpinner(2);
    }

}