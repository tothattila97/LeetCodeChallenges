public int Reverse(int x) {
        bool pos = x > 0;
            if (!pos)
                x *= -1;

            var stuff = x.ToString().ToCharArray().Reverse().ToArray();
            var parsed = Int32.TryParse(stuff, out var res);
            if(!parsed)
                return 0;
        
            if (!pos)
                return res * -1;
            else return res;
    }
