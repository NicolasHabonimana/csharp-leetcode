using System.Formats.Asn1;

public class Solution {
    public bool IsValid(string s) 
    {
        Stack<char> brackets = new();
        int len = s.Length;

        for(int i = 0; i < len; i++)
        {
            char c = s[i];
            if(c == '('){brackets.Push(')');}
            else if(c == '{'){brackets.Push('}');}
            else if(c == '['){brackets.Push(']');}
            else if(brackets.Count == 0 || c != brackets.Pop()){return false;}
        }
        return brackets.Count == 0;
    }
}
