public class MinStack {

    Stack<int> stack = new Stack<int>();
        int min = int.MaxValue;
        public MinStack() { }

        public void Push(int x)
        {
          
            if (min >= x)
            {
                if(stack.Count > 0)
                    stack.Push(min);
                min = x;
            }
            stack.Push(x);
        }

        public void Pop()
        {
            var x = stack.Pop();
            if (min == x && stack.Count != 0)
                min = stack.Pop();

            if (stack.Count == 0)
                min = int.MaxValue;
        }

        public int Top()
            => stack.Peek();

        public int GetMin()
            => min;
}
