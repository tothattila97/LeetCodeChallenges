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
