public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int zeroCount = 0;
        int prod =1;
        for (int i =0 ; i<nums.Length ; i++){
            if (nums[i]==0)
            {
                zeroCount ++ ;
            }
        }
        foreach(int n in nums)
        {
            if(n != 0)
            {
                prod = prod * n;
            }
        }
        int[] res = new int[nums.Length];
        for ( int i =0 ; i<nums.Length ; i++)
        {
            if(zeroCount > 1)
            {
                prod = 0;
            }
            else if (zeroCount > 0)
            {
                if (nums[i]==0)
                {
                    res[i]=prod;
                }
                else{
                    res[i] = 0;
                }
            }
            else{
                res[i] = prod/nums[i];
            }
        }
        return res;
    }
}
