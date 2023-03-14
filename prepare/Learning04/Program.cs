using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment fun = new MathAssignment("Tessa Hospodarsky", "fractions", "7.3", "8-19");
        Console.WriteLine(fun.GetSummary());
        Console.WriteLine(fun.GetHomeworkList());

        WritingAssignment joy = new WritingAssignment("Tessa Hospodarsky", "Personal Essay", "Listen then Speak");
        Console.WriteLine(joy.GetSummary());
        Console.WriteLine(joy.GetWritingInfo());
        //Console.WriteLine("Hello Learning04 World!");
    }
}