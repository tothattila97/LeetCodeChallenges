public bool CanPlaceFlowers(int[] flowerbed, int n) {
            int plantable = 0;
            if (flowerbed.Length == 1 && flowerbed[0] == 0 && n <= 1)
                return true;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (i - 1 < 0 && flowerbed[i] == 0 && flowerbed[i + 1] != 1)
                {
                    plantable++;
                    i++;
                }
                else if (i + 1 < flowerbed.Length && i - 1 >=0 && flowerbed[i - 1] == 0 &&
                  flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                {
                    plantable++;
                    i++;
                }
                else if (i == flowerbed.Length - 1 && flowerbed[i] == 0 && flowerbed[i - 1] == 0)
                    plantable++;
            }
            return plantable >= n;
    }
