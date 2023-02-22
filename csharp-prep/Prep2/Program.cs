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
        string grade;
        //Console.WriteLine("Hello Prep2 World!");

        // This gets the unser input for there grade percentage
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        
        Console.WriteLine($"Your grade is: {grade}");
        
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
