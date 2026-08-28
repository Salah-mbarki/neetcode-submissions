public class Solution {
    public bool ValidPalindrome(string s) {
        int l = 0 , r = s.Length-1 ;
        while ( l < r)
        {
            if ( l < r && s[l] != s[r])
            {
                string skipR = s.Substring( l , r-l);
                string skipL = s.Substring(l+1 , r-l);
                return isPalindrome(skipL) || isPalindrome(skipR);
            }
            l++;
            r--;
        }
        return true;
    }
    public bool isPalindrome(string s)
    {
        int l = 0 , r = s.Length - 1;
        while( l < r)
        {
            if (s[l] != s[r])
            {
                return false ;
                break;
            }
            l++;
            r--;
        }
        return true;
    }
}