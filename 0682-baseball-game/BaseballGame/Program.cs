using System.Diagnostics.CodeAnalysis;

public class Solution {
    public int CalPoints(string[] operations) 
    {
        int total = 0;
        Stack<int> record = new();
        for(int i = 0; i < operations.Length; i++)
        {
            var op = operations[i];
            if(int.TryParse(op, out int num)){record.Push(num);}
            else if(op == "C"){record.Pop();}
            else if(op == "D"){record.Push(record.Peek() * 2);}
            else if(op == "+")
            {
                int top = record.Pop();
                int bottom = record.Peek();
                int sum = top + bottom;
                record.Push(top);
                record.Push(sum);
            }
        }
        foreach(int score in record)
        {
            total += score;
        }
        return total;
    }
}
