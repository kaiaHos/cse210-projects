using System;

class Program
{
    /* A >= 90
    B >= 80
    C >= 70
    D >= 60
    F < 60*/
    static void Main(string[] args)
    {
        string letter;
        //Console.WriteLine("Hello Prep2 World!");

        // This gets the unser input for there grade percentage
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is: {letter}");
        
        if (percentage > 70)
        {
            Console.WriteLine("Good job passing the class!");
        }
        else 
        {
            Console.WriteLine("Keeping working on it and next time you'll pass!");
        }
    }


}
