using System.Security.Cryptography.X509Certificates;

public class Solution {
    public int FirstUniqChar(string s) 
    {
        Dictionary<char, int> characters = new Dictionary<char, int>();
        
        foreach(char c in s)
        {
            if(characters.ContainsKey(c))
            {
                characters[c]++;
            }
            else
            {
                characters[c] = 1;
            }
        }
        for(int i = 0; i < s.Length; i++)
        {
            if(characters[s[i]] == 1){return i;}
        }
        return -1;
            
    }
}
