public int[][] FlipAndInvertImage(int[][] A) {
        for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i].Reverse().ToArray();
                for (int j = 0; j < A[0].Length; j++)
                {
                    if (A[i][j] == 0)
                        A[i][j] = 1;
                    else
                        A[i][j] = 0;
                }
            }
            return A;
    }
