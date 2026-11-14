public class Solution {
    public int MajorityElement(int[] nums) 
    {
        Dictionary<int, int> numberTracker = new();
        foreach(int c in nums)
        {
            if(numberTracker.ContainsKey(c))
            {
                numberTracker[c]++;
            }
            else
            {
                numberTracker[c] = 1;
            }
            if(numberTracker[c] > nums.Length/2)
            {
                return c;
            }
        }
        return -1;
    }
}
