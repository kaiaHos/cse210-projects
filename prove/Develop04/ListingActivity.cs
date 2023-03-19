


public class ListingActivity: Activity
{
    private List<string> _prompts = new List<string>{"What things are you grateful for?", "What acts of kindness have you done?", "What are personal strengths of yours?", "Who are the heros in your life?", "What hobbies do you have?"};
    private List<string> _userInputs = new List<string>();

    public ListingActivity() : base("This activity helps you list the different things about your day. It also helps you focus on a certain part of what you do each day.", "Listing")
    {

    }

    public void GetAndDisplayPrompt()
    {
        PrintStartMessage();
        //Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        int promptCount = _prompts.Count();
        int RandomNum = new Random().Next(0, promptCount);
        Console.WriteLine(_prompts[RandomNum]);
        
        while (DateTime.Now < futureTime)
        {
            GetUserInput();
        }

        
        PrintEndMessage();
        //displaySpinner(2);
    }

    public void GetUserInput()
    {
        Console.Write("*");
        _userInputs.Add(Console.ReadLine());
    }

}