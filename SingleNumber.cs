public int SingleNumber(int[] nums) {
         var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.TryGetValue(nums[i], out _))
                    map.Remove(nums[i]);
                else
                    map.Add(nums[i], 1);
            }
            return map.First().Key;
    }
