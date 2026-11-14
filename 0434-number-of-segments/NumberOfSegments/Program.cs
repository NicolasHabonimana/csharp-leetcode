public class Solution 
{
    public int CountSegments(string s) 
    {
        int count = 0;
        bool inSegment = false;
        for(int i=0; i<s.Length; i++)
        {
            if(s[i]!= ' ' && !inSegment)
            {
                inSegment = true;
                count++;
            }
            else if(s[i]== ' ')
            {
                inSegment = false;
            }
        }
        return count;
    }
}