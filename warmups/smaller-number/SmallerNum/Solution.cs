public class Program
{
    public static void Main()
    {
        string number1 = "22";
        string number2 = "44";

        Solution mySolution = new Solution();
        string output = Solution.FindMin(number2, number1);
        Console.WriteLine(output);
    }
}