            if (nums.Length == 0)
                return 0;

            for (int i = 0; i < nums.Length -1 ; i++)
            {
                for (int j = i + 1;  j < nums.Length;  j++)
                {
                    if (nums[i] == nums[j])
                    {
                        nums[j] = -1;
                    }
                    else break;
                }
            }
            Array.Sort(nums);
            int it = 0;
            while(nums[it] == -1)
            {
                it++;
            }
            Array.Copy(nums, it, nums, 0, nums.Length - it);
            Array.Resize(ref nums, nums.Length - it);
            return nums.Count();
