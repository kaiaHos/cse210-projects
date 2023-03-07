using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(6, 7);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalNumber());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalNumber());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalNumber());

        f3.SetTop(1);
        f3.SetBottom(3);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalNumber());


        //Console.WriteLine("Hello Learning03 World!");
    }
}