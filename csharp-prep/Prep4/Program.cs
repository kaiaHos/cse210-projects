using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int number;
        int count = 0;
        int biggest = 0;

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number > 0 || number < 0)
            {
                sum = sum + number;
                numbers.Add(number);
                count = count + 1;
            }

            if(number > biggest)
            {
                biggest = number;
            }
            
        } while (number != 0);

        Console.WriteLine($"The sum is: {sum}");
        double average = ((double)sum) / (count);
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {biggest}");
        //Console.WriteLine("Hello Prep4 World!");
    }
}