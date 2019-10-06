public void Merge(int[] nums1, int m, int[] nums2, int n) {
       for (int i = 0; i < n; i++)
            {
                for (int j = m+i; j < nums1.Length; j++)
                {
                    nums1[j] = nums2[i];
                    break;
                }
                continue;
            }            
            Array.Sort(nums1); 
    }
