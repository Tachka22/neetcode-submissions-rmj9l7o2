public class Solution {
    public int LengthOfLastWord(string s) {
         var arr = s.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
         return arr[arr.Length - 1].Length;
    }
}