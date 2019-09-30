 public int FirstMissingPositive(int[] nums) {
        if (nums == null || nums.Length == 0)
                return 1;
        int numMin = nums[0] > 0 ? nums[0] : 0; int numMax = nums[0] > 0 ? nums[0] : 0;
            var validElements = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    validElements.Add(nums[i]);
                if (nums[i] < numMin && nums[i] > 0)
                    numMin = nums[i];
                if (nums[i] > numMax)
                    numMax = nums[i];
            }

            if (numMin > 1 ||validElements.Count == 0 ||(validElements.Count == 1 && validElements[0] != 1))
                return 1;
            else
            {
                validElements = validElements.OrderBy(x => x).ToList();
                if (validElements[0] - 0 != 1)
                    return 1;
                for (int i = 0; i < validElements.Count -1; i++)
                {
                    if (validElements[i + 1] - validElements[i] > 1)
                        return validElements[i] + 1;
                }
                return numMax + 1;
            }
    }
