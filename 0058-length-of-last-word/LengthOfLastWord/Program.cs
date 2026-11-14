public class Solution {
    public int LengthOfLastWord(string s) 
    {
        Stack<char> tempStack = new();
        int len = 0;
        foreach(char c in s)
        {
            tempStack.Push(c);
        }
        for(int i=0; i < s.Length; i++)
        {
            if(tempStack.Peek() == ' ')
            {
                tempStack.Pop();
            }
        }
        while(tempStack.Peek() != ' ')
        {
            tempStack.Pop();
            len++;
        }
        return len;
    }
}