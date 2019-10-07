// Note: The algorithm should run in linear time and in O(1) space.
// However the dictionary use O(n) space, so this is not a nice solution.

public int MajorityElement(int[] nums) {
        
            var majorityCount = Math.Floor((decimal)nums.Length / 2);
            var dict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dict.TryGetValue(item, out _))
                    dict[item]++;
                else
                    dict.Add(item,1);
            }
            return dict.SingleOrDefault(x => x.Value > majorityCount).Key;  
    }
