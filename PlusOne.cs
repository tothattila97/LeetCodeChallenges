 public int[] PlusOne(int[] digits) {
        if (digits == null || digits.Length == 0)
                return digits;

            var carry = 0;
            var length = digits.Length -1;

            var i = length;
            while(i>=0 && digits[i] == 9)
            {
                carry++;
                i--;
            }
            var newDigits = new int[digits.Length + 1];
            if (carry == digits.Length)
            {
                Array.Copy(digits, 0, newDigits, 1, digits.Length);
                return Calculate(newDigits);
            }
            else
                return Calculate(digits);

            int[] Calculate(int[] array)
            {
                for (int j = array.Length - 1; j > array.Length - 1 - carry; j--)
                {
                    array[j] = 0;
                }
                array[array.Length - 1 - carry]++;
                return array;
            }
    }
