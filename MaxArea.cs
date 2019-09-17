 public int MaxArea(int[] height) {
        int area = 0;
            for (int i = 0; i < height.Length -1; i++)
            {
                for(int j = i+1; j< height.Length; j++)
                {
                    int width = j - i;
                    int heigh = Math.Min(height[j], height[i]);
                    if (width * heigh > area) { area = width * heigh; }
                }
            }
            return area;
    }
