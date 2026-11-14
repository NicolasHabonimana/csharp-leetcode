public class Solution
{
    public static int HowManyD(string sentence)
    {
        int dCount = 0;
        foreach(char i in sentence)
        {
            if(i == 'd'){dCount ++;}
            if(i == 'D'){dCount ++;}
        }
        return dCount;
    }
}