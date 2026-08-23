public class Solution {
    public void ReverseString(char[] s) {
        int l = 0 ;
        int r = s.Length-1 ;
        char aux ;
        while ( l < r )
        {
            aux = s[l];
            s[l] = s[r];
            s[r] = aux ;
            l++ ; r-- ;
        }
    }
}