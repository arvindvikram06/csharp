using System;
using System.IO;
using System.IO.Pipelines;

class FileProcessor
{
    static void Main()
    {
        String inputfile = "input.txt";
        String output = "output.txt";
        try{
        string[] lines = File.ReadAllLines(inputfile);
        int lineCount = lines.Length;
        int wordCount = 0;

        foreach(string line in lines)
        {
            string[] words = line.Split(" ",StringSplitOptions.RemoveEmptyEntries);
             wordCount += words.Length;
        }

        string result = $"The total lines count is {lineCount} and the total wordCount is {wordCount}";

        File.WriteAllText(output,result);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File doesnt exist");
        }
        catch(IOException ex)
        {
            Console.WriteLine("IO Error" + ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Unexpected Error" + ex.Message);
        }
    }
}