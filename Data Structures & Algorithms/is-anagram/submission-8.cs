public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        };
        char[] Arrays = s.ToCharArray();
        char[] ArrayT = t.ToCharArray();
        Array.Sort(Arrays);
        Array.Sort(ArrayT);
        return Arrays.SequenceEqual(ArrayT);
        
    }
}
