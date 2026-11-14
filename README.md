# C# LeetCode Solutions

My solutions to LeetCode problems, written in C#. I use these to practice data structures and get better at problem solving for technical interviews.

Each folder is its own small .NET project with the solution in `Solution.cs` (or `Program.cs`).

## Solved problems

### Stacks & queues

| # | Problem | My approach |
|---|---------|-------------|
| 20 | [Valid Parentheses](https://leetcode.com/problems/valid-parentheses/) | Push the expected closing bracket on a stack, pop and compare when a closing bracket comes. O(n) |
| 58 | [Length of Last Word](https://leetcode.com/problems/length-of-last-word/) | Push the characters on a stack, skip trailing spaces, then count until the next space |
| 283 | [Move Zeroes](https://leetcode.com/problems/move-zeroes/) | Queue the non-zero values, add the zeroes at the end, write back to the array. O(n) |
| 344 | [Reverse String](https://leetcode.com/problems/reverse-string/) | Push every character on a stack and pop them back into the array |
| 682 | [Baseball Game](https://leetcode.com/problems/baseball-game/) | Stack of scores, handle `C`, `D` and `+` operations, then sum the stack |
| 933 | [Number of Recent Calls](https://leetcode.com/problems/number-of-recent-calls/) | Sliding window with a queue, drop pings older than `t - 3000` |
| 1700 | [Number of Students Unable to Eat Lunch](https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/) | Simulate the line with two queues and stop when a full rotation makes no progress |

### Hash maps

| # | Problem | My approach |
|---|---------|-------------|
| 169 | [Majority Element](https://leetcode.com/problems/majority-element/) | Count with a `Dictionary` and return as soon as a count is bigger than n/2. O(n) |
| 387 | [First Unique Character in a String](https://leetcode.com/problems/first-unique-character-in-a-string/) | Count every character, then a second pass finds the first one with count 1. O(n) |

### Two pointers

| # | Problem | My approach |
|---|---------|-------------|
| 27 | [Remove Element](https://leetcode.com/problems/remove-element/) | Write pointer `k` that copies only the values to keep. O(n) time, O(1) space |
| 88 | [Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/) | Three pointers merging from the back so nothing gets overwritten. O(m + n) time, O(1) space |

### Strings

| # | Problem | My approach |
|---|---------|-------------|
| 28 | [Find the Index of the First Occurrence in a String](https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/) | Uses the built-in `IndexOf` |
| 434 | [Number of Segments in a String](https://leetcode.com/problems/number-of-segments-in-a-string/) | One pass with an "inside a word" flag. O(n) time, O(1) space |
| 1768 | [Merge Strings Alternately](https://leetcode.com/problems/merge-strings-alternately/) | Take one character from each word in turn up to the longer length |

### Math & bit manipulation

| # | Problem | My approach |
|---|---------|-------------|
| 202 | [Happy Number](https://leetcode.com/problems/happy-number/) | Recursive sum of squared digits; for one digit numbers only 1 and 7 are happy |
| 389 | [Find the Difference](https://leetcode.com/problems/find-the-difference/) | XOR all the characters of both strings, the extra one is what is left. O(1) space |
| 657 | [Robot Return to Origin](https://leetcode.com/problems/robot-return-to-origin/) | Track x and y, check both are back to 0 |
| 724 | [Find Pivot Index](https://leetcode.com/problems/find-pivot-index/) | Running left sum vs. remaining right sum. O(n) time, O(1) space |

## Warm-ups

Shorter beginner exercises in [`warmups/`](warmups): counting a letter in a sentence, min and max of an array, sum of an array, multiplying by the array length, and comparing two numbers given as strings.

## Run a solution

You need the [.NET SDK](https://dotnet.microsoft.com/download). Open the `.sln` file of any problem in Visual Studio or Rider, or run it from its project folder:

```bash
cd 0020-valid-parentheses/ValidParentheses
dotnet build
```
