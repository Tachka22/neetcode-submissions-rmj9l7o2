public class Solution {
    public int[] ReplaceElements(int[] arr) {
        for(var i = 0; i < arr.Length - 1; i++)
        {
            var max = 0;
            for(var j = i + 1; j < arr.Length; j++)
            {
                max = Math.Max(arr[j], max);
            }
            arr[i] = max;
        }

        arr[arr.Length - 1] = -1;
        return arr;
    }
}