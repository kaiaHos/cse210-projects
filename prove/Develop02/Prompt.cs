
public class GeneratePrompt
{
    public string _randomPrompt = "";
    //List<string> prompts = new  List<string>();
    
    public void /*string*/ Prompt()
    {
        string[] prompts = {"What miracles did you see in your life today?", "What are some of your jobs at home?", "What do you think of yourself?",
                            "What is the weirdest dream you've ever had?", "Do you like school? Why?", "When were you parents most proud of you?",
                            "What is the most valuable principle you've learned through your experience with others?"};
     
        //This holds the random number used to determine which prompt to display
        int randomNumber = new Random().Next(0, 8); // 
        _randomPrompt = prompts[randomNumber];
        Console.Write($"{_randomPrompt} ");
        //return _randomPrompt;

    }

}


// Link used to figure out how to do random in C sharp
// https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp