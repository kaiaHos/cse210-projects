using System;

class Program
{
    
    static void Main(string[] args)
    {
        string verse = "Learn of me, and listen to my words; walk in the meekness of my Spirit, and you shall have peace in me.";
        Reference rf = new Reference( "D&C", "19", "23");
        Scripture newScripture = new Scripture(rf, verse);

        Console.Clear();
        Console.Write("Please enter how many words would you like to hide at a time: ");
        int numOfWords = int.Parse(Console.ReadLine());
        
        Console.WriteLine(newScripture.GetScripture());
        Console.WriteLine("To quit type quit, to continue hit enter");
        string answer = Console.ReadLine();
        Boolean hidden = newScripture.FullyHidden();

        while (answer.ToLower() != "quit" && hidden == false)
        {
           Console.Clear(); 
            newScripture.HideWords(numOfWords);
            Console.WriteLine(newScripture.GetScripture());
            Console.WriteLine("To quit type quit, to continue hit enter");
            answer = Console.ReadLine();
            hidden = newScripture.FullyHidden();
        } 

        //Console.WriteLine("Hello Develop03 World!");
    }
}