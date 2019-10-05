public ListNode DeleteDuplicates(ListNode head) {
        if (head == null || head.next == null)
                return head;

            var list = new List<int> { head.val };

            while (head.next != null)
            {
                if (head.val != head.next.val)
                    list.Add(head.next.val);

                head = head.next;
            }
            list.Reverse();
            var temp = new ListNode(list[0]);
            for (int i = 1; i < list.Count; i++)
            {
                var uj = new ListNode(list[i])
                {
                    next = temp
                };
                temp = uj;
            }
            return temp;
    }
