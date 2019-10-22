public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var remainedElements = new List<int>();
            var len = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                    len--;
                else
                    remainedElements.Add(nums[i]);
            }
            Array.Clear(nums, 0, nums.Length);
            Array.Copy(remainedElements.ToArray(), 0, nums, 0, remainedElements.Count);
            return len;
    }
}
