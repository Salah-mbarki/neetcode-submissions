public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false ;
        }
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();
        Array.Sort(sArray);
        Array.Sort(tArray);
        if(sArray.SequenceEqual(tArray))
        {
            return true ;
        }
        else {
            return false;
        }
    }
}
