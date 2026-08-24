public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var s = new StringBuilder();
        int i =0;
        while (i < word1.Length || i <word2.Length)
        {
            if( i < word1.Length ) s.Append(word1[i]);
            if( i < word2.Length ) s.Append(word2[i]);
            i++;
        }
        return s.ToString();
    }
}