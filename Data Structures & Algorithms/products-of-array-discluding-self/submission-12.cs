public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int zeroCount = 0;
        int prod = 1;
        foreach(int n in nums)
        {
            if (n != 0)
            {
                prod = prod * n;
            }
            else 
            {
                zeroCount ++ ; 
            }
        }
        if(zeroCount > 1 )
        {
            return new int[nums.Length];
        }
        int[] res = new int[nums.Length];
        for (int i = 0 ; i<nums.Length ; i++)
        {
            if (zeroCount > 0 )
            {
                if (nums[i] == 0){
                    res[i] = prod;
                }
                else {
                    res[i] = 0;
                }
            }
            else {
                res[i] = prod / nums[i] ;
            }
        }
        return res ;
    }
}
