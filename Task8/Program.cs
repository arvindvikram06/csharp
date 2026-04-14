using System;
using System.Collections.Generic;

public interface IRepository<T>
{
    void Add(T item);
    List<T> GetAll();
    T Get(int index);
    void Update(int index, T item);
    void Delete(int index);
}

public class Repository<T> : IRepository<T>
{
    private List<T> data = new List<T>();

    public void Add(T item) => data.Add(item);

    public List<T> GetAll() => data;

    public T Get(int index) => (index >= 0 && index < data.Count) ? data[index] : default(T);

    public void Update(int index, T item)
    {
        if (index >= 0 && index < data.Count)
            data[index] = item;
    }

    public void Delete(int index)
    {
        if (index >= 0 && index < data.Count)
            data.RemoveAt(index);
    }
}

public class Student
{
    public string Name;
    public int Age;

    public override string ToString() => $"Name: {Name}, Age: {Age}";
}

class Program
{
    static void Main()
    {
        var repo = new Repository<Student>();

        while (true)
        {
            Console.WriteLine("\n1.Add 2.View 3.Update 4.Delete 5.Exit");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                var name = Console.ReadLine();
                var age = int.TryParse(Console.ReadLine(), out var a) ? a : 0;
                repo.Add(new Student { Name = name, Age = age });
            }
            else if (choice == "2")
            {
                var list = repo.GetAll();
                for (int i = 0; i < list.Count; i++)
                    Console.WriteLine($"{i}: {list[i]}");
            }
            else if (choice == "3")
            {
                var i = int.Parse(Console.ReadLine());
                var name = Console.ReadLine();
                var age = int.Parse(Console.ReadLine());
                repo.Update(i, new Student { Name = name, Age = age });
            }
            else if (choice == "4")
            {
                var i = int.Parse(Console.ReadLine());
                repo.Delete(i);
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}