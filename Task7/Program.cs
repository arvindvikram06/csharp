using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            var task1 = DataFetcher.FetchFromSourceAsync("Facebook", 2000);
            var task2 = DataFetcher.FetchFromSourceAsync("Youtube", 3000);
            var task3 = DataFetcher.FetchFromSourceAsync("Instagram", 1000);

            Console.WriteLine("All tasks started\n");

            var results = await Task.WhenAll(task1, task2, task3);


            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n[ERROR] {ex.Message}");
        }
    }
}