// See https://aka.ms/new-console-template for more information
using System;

class Person
{
    string name;
    int age;

    public Person(string name,int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi,my name is {this.name} and my age is {this.age}");
    }
    
}

public class Program
{
    public static void Main()
    {
        Person p1 = new Person("arvind",21);
        Person p2 = new Person("vijay",20);

        p1.Introduce();
        p2.Introduce();
    }
}