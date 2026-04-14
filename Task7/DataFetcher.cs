using System;
using System.Threading.Tasks;

class DataFetcher
{
    public static async Task<string> FetchFromSourceAsync(string sourceName, int delay)
    {
        Console.WriteLine($"[START] Fetching from {sourceName}");

        await Task.Delay(delay); 

        if (sourceName == "Youtube")
        {
            throw new Exception("Error while fetching from Source2");
        }

        Console.WriteLine($"[END] Fetching from {sourceName}");

        return $"Data from {sourceName}";
    }
}