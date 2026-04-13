using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        string num = Console.ReadLine();

        if (!int.TryParse(num, out int number) || number < 0)
        {
            return;
        }

        long fact = factorial(number);
        Console.WriteLine(fact);

        Console.WriteLine("the factorial of number " + number + " is " + fact);
    }

    public static long factorial(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }
        return num * factorial(num - 1);
    }
}
