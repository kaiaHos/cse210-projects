
public class Entry
{
    public string _userEntry = "";
    public string _entryPrompt = "";
    public string _date = "";
    public void Display()
    {
        Console.WriteLine($"Date: {_date} -- Promt: {_entryPrompt}");
        Console.WriteLine(_userEntry);
    }
}