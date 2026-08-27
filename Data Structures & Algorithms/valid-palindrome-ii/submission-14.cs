public class Solution {
    public bool ValidPalindrome(string s) {
        int l = 0 , r = s.Length -1;
        if (isPalindrome(s)){
            return true;
        }
        while( l < r ){
            if ( s[l] != s[r]){
                string skipL = s.Substring(l+1 , r-l) ;
                string skipR = s.Substring(l , r-l);
                return (isPalindrome(skipL) || isPalindrome(skipR));
            }
            l++;
            r--;
        }
        return false;
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