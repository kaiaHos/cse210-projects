using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Fedelis Cybersecurity";
        job1._startYear = 2003;
        job1._endYear = 2012;

        Job job2 = new Job();
        job2._jobTitle = "Photographers Assistant";
        job2._company = "MarDel Photography";
        job2._startYear = 2021;
        job2._startYear = 2023;

        job1.DisplayJobInfo();
        //Console.WriteLine(job1._company);
        //Console.WriteLine(job2._company);

    }
}