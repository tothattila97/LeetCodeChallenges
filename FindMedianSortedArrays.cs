public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var len = nums1.Length + nums2.Length;
            bool odd = false;
            if (len % 2 == 1)
                odd = true;

            int nums1Idx = 0; int nums2Idx = 0;
            var median = new int[len / 2+1];
            for (int i = 0; i < len / 2+1; i++)
            {
                if(nums1Idx == nums1.Length)
                {
                    median[i] = nums2[nums2Idx];
                    nums2Idx++;
                }
                else if (nums2Idx == nums2.Length)
                {
                    median[i] = nums1[nums1Idx];
                    nums1Idx++;
                }
                else if (nums1[nums1Idx] <= nums2[nums2Idx])
                {
                    median[i] = nums1[nums1Idx];
                    nums1Idx++;
                }
                else
                {
                    median[i] = nums2[nums2Idx];
                    nums2Idx++;
                }
            }
            if (odd)
                return median[len / 2];
            else
                return (double)(median[len / 2] + median[len / 2 - 1]) / 2;
    }
