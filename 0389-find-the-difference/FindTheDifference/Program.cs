public class Solution 
{
    public char FindTheDifference(string s, string t) 
    {
        char result = ' ';

        foreach(char c in s)
        {
            result ^= c;
        }
        foreach(char c in t)
        {
            result ^= c;
        }

        return result;

    }
}