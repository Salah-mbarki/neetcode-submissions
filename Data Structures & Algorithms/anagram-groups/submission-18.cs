public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary < string , List<string>> dict = new Dictionary < string , List<string>>();

        foreach(var str in strs)
        {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string sorted = new string(charArray);
            if (!dict.ContainsKey(sorted))
            {
                dict[sorted] = new List<string>();
            }
            dict[sorted].Add(str);
        }
        
        return dict.Values.ToList<List<string>>();

    }
}
