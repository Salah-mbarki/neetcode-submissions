public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false ;
        }
        Dictionary<char , int> CountS = new Dictionary<char , int>();
        Dictionary<char , int> CountT = new Dictionary<char , int>();

        for (int i =0; i<s.Length ; i++) {
            CountS[s[i]] = CountS.GetValueOrDefault(s[i] , 0) + 1 ;
            CountT[t[i]] = CountT.GetValueOrDefault(t[i] , 0) + 1 ;
        }
        return CountS.Count == CountT.Count && !CountS.Except(CountT).Any();
    }
}
