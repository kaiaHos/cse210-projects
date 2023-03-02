using System;




public class Journals
{
     public List<Entry> _entries = new List<Entry>();
    public void SaveFile()
    {


    }
    public void LoadFile()
    {


    }
    public void AddEntry()
    {
        GeneratePrompt newPromt = new GeneratePrompt();
        Entry newEntry = new Entry();


        newPromt.Prompt();
        string entryFromUser = Console.ReadLine();


        newEntry._userEntry = entryFromUser;
        newEntry._entryPrompt = newPromt._randomPrompt;
        newEntry._date = "3/2/2023";


    }
    public void DisplayEntries()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }
}
