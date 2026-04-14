public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        
        var seen = new Dictionary<char, int>();
        foreach(var c in s)
        {
            if(seen.ContainsKey(c))
                seen[c]++;
            else
                seen[c] = 1;
        }

        foreach(var c in t)
        {
            if(!seen.ContainsKey(c) || seen[c] == 0)
            {
                return false;
            }
            seen[c]--;
        }
        return true;
    }
}
