public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) 
    {
        Queue<int> studentNum = new Queue<int>();
        Queue<int> sandwichNum = new Queue<int>();
        int total = 0;
        foreach(int c in students)
        {
            studentNum.Enqueue(c);
        }
        foreach(int s in sandwiches)
        {
            sandwichNum.Enqueue(s);
        }
        while(studentNum.Count > 0 && total < studentNum.Count)
        {
            if(studentNum.Peek() == sandwichNum.Peek())
            {
                studentNum.Dequeue();
                sandwichNum.Dequeue();
                total = 0;
            }
            else if(studentNum.Peek() != sandwichNum.Peek())
            {
                int tempStudent = studentNum.Dequeue();
                studentNum.Enqueue(tempStudent);
                total++;
            }
        }
        return total;
    }
}
