public uint reverseBits(uint n)
        => Convert.ToUInt32(string.Concat(Convert.ToString(n, 2).PadLeft(32, '0').Reverse()), 2);
