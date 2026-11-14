using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Type a sentence I will count how many d");
        string sentence = Convert.ToString(Console.ReadLine());
        Solution mySolution = new Solution();
        int output = Solution.HowManyD(sentence);
        Console.WriteLine(output);
    }
}