public class Solution {
    public void ReverseString(char[] s) 
    {
        Stack<char> temp = new();
        foreach(char t in s)
        {
            temp.Push(t);
        }
        for(int i=0; i<s.Length; i++)
        {
            s[i] = temp.Pop();
        }
    }
}