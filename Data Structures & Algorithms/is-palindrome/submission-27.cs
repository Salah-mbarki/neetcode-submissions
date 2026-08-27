public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0 , r = s.Length - 1;
        while ( l < r ){
            while ( l < r && !AlphaNum(s[l])){
                l++;
            }
            while ( l < r && !AlphaNum(s[r])){
                r--;
            }
            if ( Char.ToUpper(s[l]) != char.ToUpper(s[r])){
                return false ;
            }
            l++;
            r--;
        }
        return true;
    }
    public bool AlphaNum(char c )
    {
        return ( c >= 'a' && c <= 'z' ||
                 c >= 'A' && c <= 'Z' ||
                 c >= '0' && c <= '9');
    }
}
