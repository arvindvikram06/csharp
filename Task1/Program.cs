using System;

        Console.WriteLine("Enter the number");
        string num = Console.ReadLine();

        if (!int.TryParse(num, out int number) || number < 0)
        {
            return;
        }

        long fact = factorial(number);
        Console.WriteLine(fact);

        Console.WriteLine("the factorial of number " + number + " is " + fact);


      long factorial(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }
        return num * factorial(num - 1);
    }
