public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary <int , int > freq = new Dictionary <int , int > ();
        foreach ( var n in nums)
        {
            if (!freq.ContainsKey(n)){
                freq[n] = 1;
            }
            else 
            {
                freq[n]++;
            }
        }
        List<int[]> arr = freq.Select(entry => new int[] {entry.Value , entry.Key}).ToList();
        arr.Sort((a,b) => b[0].CompareTo(a[0]));
        int[] res = new int[k];
        for (int i =0 ; i< k ; i++)
        {
            res[i] = arr[i][1];
        }
        return res ;
        
    }
}
