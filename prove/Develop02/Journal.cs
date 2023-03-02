using System;
using System.IO; 




public class Journal
{
     public List<Entry> _entries = new List<Entry>();
    public void SaveFile()
    {
        Console.Write("Please enter the file name? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile  = new StreamWriter(fileName))
        {
            outputFile.WriteLine("This is my Journal full of things I want to remember: date, prompt, journal entry");

            foreach(Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date}||{entry._entryPrompt}||{entry._userEntry}");
        }

        }
        
    }
    public void LoadFile()
    {
        Console.Write("Please enter the file name? ");
        string fileName = Console.ReadLine();
        int count = 0;

        string[] file = System.IO.File.ReadAllLines(fileName);

        // line in this format  date||prompt||journalEntry
        foreach (string line in file)
        {
            // this allows us to skip the header of the file.
            if (count > 0)
            {
                Entry oldEntry = new Entry();

                string[] parts = line.Split("||");

                oldEntry._userEntry = parts[2];
                oldEntry._entryPrompt = parts[1];
                oldEntry._date = parts[0];
                _entries.Add(oldEntry);
            }
            else if (count == 0)
            {
                count = count + 1;
            }
           
        }

    }
    public void AddEntry()
    {
        GeneratePrompt newPromt = new GeneratePrompt();
        Entry newEntry = new Entry();

        newPromt.Prompt();
        string entryFromUser = Console.ReadLine();

        newEntry._userEntry = entryFromUser;
        newEntry._entryPrompt = newPromt._randomPrompt;

        DateTime theCurrentTime = DateTime.Now;
        newEntry._date = theCurrentTime.ToShortDateString();

        _entries.Add(newEntry);
    }
    public void DisplayEntries()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
}
