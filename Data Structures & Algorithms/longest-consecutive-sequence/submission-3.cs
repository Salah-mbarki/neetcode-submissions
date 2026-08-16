public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> tab = new HashSet<int>(nums);
        int longestStreak = 0;
        int currentStreak = 0;
        foreach(var n in tab)
        {
            if (!tab.Contains(n-1))
            {
                currentStreak =0;
                while (tab.Contains(n + currentStreak))
                {
                    currentStreak++;
                }
                longestStreak = Math.Max(longestStreak,currentStreak);
            }
            
        }
        return longestStreak;
    }
}
