public bool ContainsDuplicate(int[] nums) {
        var dict = new Dictionary<int, int>(); // key: value, value: count
            foreach (var item in nums)
            {
                if (dict.TryGetValue(item, out _))
                    return true;
                else
                    dict.Add(item, 1);
            }
            return false;
    }
