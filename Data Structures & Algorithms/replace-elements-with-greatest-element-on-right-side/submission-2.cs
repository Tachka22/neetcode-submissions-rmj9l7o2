public class Solution {
    public int[] ReplaceElements(int[] arr) {
        var len = arr.Length;
        var ans = new int[len];
        var max = -1;
        for(var i = len - 1; i >= 0; i--)
        {
            ans[i] = max;
            max = Math.Max(arr[i], max);
        }
        return ans;
    }
}