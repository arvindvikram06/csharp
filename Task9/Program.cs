using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();

        foreach (Type type in assembly.GetTypes())
        {
            Console.WriteLine("type" + type);
            foreach (MethodInfo method in type.GetMethods())
            {
                if (method.GetCustomAttribute(typeof(RunnableAttribute)) != null)
                {
                    object instance = method.IsStatic ? null : Activator.CreateInstance(type);

                    Console.WriteLine($"Executing: {type.Name}.{method.Name}");

                    method.Invoke(instance, null);
                }
            }
        }
    }
}