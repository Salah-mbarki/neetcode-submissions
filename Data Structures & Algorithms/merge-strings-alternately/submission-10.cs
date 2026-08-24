public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string s = "";
        int i =0;
        char[] ch1 = word1.ToCharArray();
        char[] ch2 = word2.ToCharArray();

        if ( ch1.Length > ch2.Length)
        {
            while (i < ch2.Length)
            {
                s += ch1[i].ToString() + ch2[i].ToString();
                i++;
            }
            s += word1.Substring(i , word1.Length - i);
        }
        else if ( ch1.Length < ch2.Length)
        {
            while (i < ch1.Length)
            {
                s += ch1[i].ToString() + ch2[i].ToString();
                i++;
            }
            s += word2.Substring(i , word2.Length - i);
        }
        else 
        {
            while (i < ch1.Length)
            {
                s += ch1[i].ToString() + ch2[i].ToString();
                i++;
            }
        }
        return s;
    }
}