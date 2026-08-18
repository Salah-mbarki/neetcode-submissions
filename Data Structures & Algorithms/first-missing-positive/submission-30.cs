public class Solution {
    public int FirstMissingPositive(int[] nums) {
        HashSet<int> existing = new HashSet<int>();

        // Only store positive numbers
        foreach (int n in nums) {
            if (n > 0) {
                existing.Add(n);
            }
        }

        // Start from 1 and find the first missing positive
        int res = 1;
        while (existing.Contains(res)) {
            res++;
        }

        return res;
    }
}