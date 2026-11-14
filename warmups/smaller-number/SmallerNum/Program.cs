using Microsoft.Win32.SafeHandles;

public class Solution
{
    public static string FindMin(string num1, string num2)
    {   
        string minVal = "";
        if(num1.Length < num2.Length){return minVal = num1;}
        else if(num1.Length > num2.Length){return minVal =num2;}
        else if(num1.Length == num2.Length){return minVal = num2;}
        return minVal;
    }
}
