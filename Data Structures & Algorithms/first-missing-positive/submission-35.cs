public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;

        // Step 1: Place each number in its "correct" index if possible
        // We only care about numbers in the range [1, n]
        for (int i = 0; i < n; i++) {
            // While the current number is in range [1, n]
            // and is not already in the correct position
            while (nums[i] >= 1 && nums[i] <= n && nums[nums[i] - 1] != nums[i]) {
                // Swap nums[i] with the number at its correct index
                int correctIndex = nums[i] - 1;
                int temp = nums[i];
                nums[i] = nums[correctIndex];
                nums[correctIndex] = temp;
            }
        }

        // Step 2: Find the first index that does not contain the expected number
        for (int i = 0; i < n; i++) {
            if (nums[i] != i + 1) {
                return i + 1;
            }
        }

        // If all numbers from 1 to n are present, the answer is n + 1
        return n + 1;
    }
}