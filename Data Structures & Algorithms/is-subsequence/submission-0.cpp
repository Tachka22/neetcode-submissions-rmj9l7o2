class Solution {
public:
    bool isSubsequence(string s, string t) {
        if (s.empty()) 
         return true;
        if (t.empty())
            return false;

        int p_s = 0;
        int p_t = 0;
        
        while (p_t < t.size()) {
            if (s[p_s] == t[p_t]) {
                p_s++;
            }
            if (p_s == s.size()) {
                return true;
            }
            p_t++;
        }
        
        return false;
    }
};
