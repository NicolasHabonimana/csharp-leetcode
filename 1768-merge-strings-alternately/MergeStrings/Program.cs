public class Solution 
{
    public string MergeAlternately(string word1, string word2) 
    {
        List<char> letters1 = new List<char>();
        List<char> letters2 = new List<char>();

        for(int i = 0; i<word1.Length; i++)
        {
            letters1.Add(word1[i]);
        }
        for(int i = 0; i<word2.Length; i++)
        {
            letters2.Add(word2[i]);
        }
        
        int maxLength = Math.Max(letters1.Count, letters2.Count);

        List<char> results = new List<char>();

        for(int i = 0; i<maxLength; i++)
        {
            if(i<letters1.Count){results.Add(letters1[i]);}
            if(i<letters2.Count){results.Add(letters2[i]);}
        }
        return new string(results.ToArray());
    }
}