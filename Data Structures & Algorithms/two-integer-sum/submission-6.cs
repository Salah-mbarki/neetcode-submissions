public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> Aux = new Dictionary<int,int>();
        for (int i = 0; i <nums.Length ; i++){
            Aux[nums[i]] = i ;
        }
        for (int i = 0 ; i<nums.Length ; i++){
            int diff = target - nums[i] ;
            if (Aux.ContainsKey(diff) && Aux[diff]!=i){
                return new int[] {i,Aux[diff]};
            }
        }
        return new int[0];
    }
}
