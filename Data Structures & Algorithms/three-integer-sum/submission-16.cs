public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        Array.Sort(nums);
        for(int i =0 ; i<nums.Length-2 ; i++)
        {
            if ( i > 0 && nums[i] == nums[i - 1]) continue;
            int l = i+1;
            int r = nums.Length-1;
            while(l < r)
            {
                int sum = nums[i] + nums[l] + nums[r];
                if( sum < 0){
                    l++;
                }
                else if (sum > 0){
                    r--;
                }
                else {
                    res.Add(new List<int> {nums[i] ,nums[l] ,nums[r]});
                    while (l < r && nums[l] == nums[l+1]){
                        l++;
                    }
                    while (r > l && nums[r] == nums[r-1]){
                        r--;
                    }
                    l++;
                    r--;
                }
            }
        }
        return res;
    }
}
