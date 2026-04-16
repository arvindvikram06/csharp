using System;

public class TaskA
{
    [Runnable]
    public void MethodOne()
    {
        Console.WriteLine("TaskA - MethodOne executed");
    }

    public void MethodTwo()
    {
        Console.WriteLine("TaskA - MethodTwo NOT executed");
    }
}