public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numbers = new HashSet<int>();
        int streak = 0;
        int currentStreak = 0;
        foreach (int n in nums)
        {
            numbers.Add(n);
        }
        foreach(int n in numbers)
        {
            if( !numbers.Contains(n-1))
            {
                currentStreak = 1;
                while (numbers.Contains(n+currentStreak))
                {
                    currentStreak ++ ;
                }
                streak = Math.Max(streak , currentStreak);
            }
        }
        return streak;
    }
}
