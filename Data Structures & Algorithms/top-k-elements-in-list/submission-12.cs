public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary <int,int> dict = new Dictionary<int , int>();
        foreach (int n in nums)
        {
            if ( dict.ContainsKey(n))
            {
                dict[n]++;
            }
            else{
                dict[n] = 1;
            }
        }
        int[] res = new int[k];
        List<int[]> arr = dict.Select(entry =>new int[] {entry.Value , entry.Key}).ToList();
        arr.Sort((a,b)=>b[0].CompareTo(a[0]));
        for (int i= 0; i<k; i++)
        {
            res[i] = arr[i][1];
        }
        return res;
    }
}
