public int SearchInsert(int[] nums, int target) {
            if (nums[0] > target)
                return 0;
            else if (nums[nums.Length - 1] < target)
                return nums.Length;
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {

                    if (nums[i] == target)
                        return i;
                    if (i+1 != nums.Length && nums[i] < target && nums[i + 1] > target)
                        return i + 1;
                }
            }
            return int.MinValue;
    }
