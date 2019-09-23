//One iteration over the array O(n)
public int MaxProfit(int[] prices) {
        if (prices.Length == 0 || prices == null)
                return 0;

            int maxProfit = 0; int minValue = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minValue)
                    minValue = prices[i];
                if (prices[i] - minValue > maxProfit)
                    maxProfit = prices[i] - minValue;
            }
            return maxProfit;
    }
    
//BruteForce solution O(n^2)
public int MaxProfit(int[] prices) {
        int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > maxProfit)
                        maxProfit = prices[j] - prices[i];
                }
            }
            return maxProfit;
    }
