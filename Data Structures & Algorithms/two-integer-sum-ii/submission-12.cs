public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
    int l = 0;
    int r = numbers.Length - 1;

    while (l < r) {
        int sum = numbers[l] + numbers[r];

        if (sum == target) {
            return new int[] { l + 1, r + 1 };   // 1-based indices
        }
        else if (sum < target) {
            l++;   // need bigger sum → move left pointer right
        }
        else {
            r--;   // need smaller sum → move right pointer left
        }
    }

    return new int[] { -1, -1 }; // should never reach here
}
}
