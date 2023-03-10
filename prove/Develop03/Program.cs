using System;

class Program
{
    
    static void Main(string[] args)
    {
        string verse = "Learn of me, and listen to my words; walk in the meekness of my Spirit, and you shall have peace in me.";
        Reference rf = new Reference( "D&C", "19", "23");
        Scripture newScripture = new Scripture(rf, verse);

        //Console.WriteLine("To quit type quit, to continue hit enter");
        do
        {
            Console.Clear();
            Console.WriteLine(newScripture.GetScripture());
            Console.WriteLine("To quit type quit, to continue hit enter");

        } while (Console.ReadLine().ToLower() != "quit" || newScripture.FullyHidden() == true);

        //Console.WriteLine("Hello Develop03 World!");
    }
}