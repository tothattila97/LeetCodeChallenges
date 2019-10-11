 public int MinSteps(int n) {
          if (n == 1) return 0;
            var factorMap = new Dictionary<int, int>();
            Factorize();

            if (factorMap.Count == 0) //prime case
                return n;    // 1 copy + n-1 paste

            return factorMap.Sum(x => x.Key * x.Value);

            void Factorize()
            {
                var ceiling = (int)Math.Ceiling((decimal)n / 2);
                for (int i = 2; i <= ceiling; i++)
                {
                    if (n == 1) break;
                    if (n % i == 0)
                    {
                        if (factorMap.TryGetValue(i, out _))
                            factorMap[i]++;
                        else
                            factorMap.Add(i, 1);

                        n /= i;
                        i = 1;
                    }
                }
            }
    }
