using System;
using System.IO;
namespace Task6.services
{
  public class LoggingService
    {
        public void LogOrder(int order)
        {
            string message = $"[LOG] {order} orders processed at {DateTime.Now}\n";

            File.AppendAllText("log.txt",message);

            Console.WriteLine("[Logger] Logged order batch");
        }
    } 
}