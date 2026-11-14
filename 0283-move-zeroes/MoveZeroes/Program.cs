public class Solution {
    public void MoveZeroes(int[] nums) 
    {
        Queue<int> numz = new();
        int zeroCount = 0;
        foreach(int i in nums)
        {
            if(i != 0)
            {
                numz.Enqueue(i);
            }
            else
            {
                zeroCount++;
            }
        }
        for(int i=0; i < zeroCount; i++)
        {
            numz.Enqueue(0);
        }
        for(int i=0; i<nums.Length; i++)
        {
            nums[i] = numz.Dequeue();
        }
    }
}
