namespace ConsoleApp1
{
    public class List
    {
        Node head;
        Node tail;
        int size = 0;

        public void insert(int val)
        {
            var val2Insert = new Node(val);
            size++;
            if (head == null && tail == null)
            {
                head = tail = val2Insert;
                head.prev = tail;
                head.next = tail;
                tail.prev = head;
                tail.next = head;
                return;
            }

            if(head == tail)
            {
                tail = val2Insert;
                head.prev = tail;
                head.next = tail;
                tail.prev = head;
                tail.next = head;
                return;
            }

            if(val < head.Val)
            {
                tail.next = val2Insert;
                val2Insert.prev = tail;
                val2Insert.next = head;
                head.prev = val2Insert;
                head = val2Insert;
                return;
            }

            var temp = head.next;

            while(temp != head && temp.Val < val )
            {
                temp = temp.next;
            }

            val2Insert.next = temp.next;
            val2Insert.prev = temp;
            temp.next = val2Insert;
        }


        public bool delete(int val) 
        {
            bool retVal = false;
            if (size == 0)
            {
                retVal = true;
            }
            else if(size == 1)
            {
                if(head.Val == val)
                {
                    head = tail = null;
                    size--;
                    retVal = true;
                }
                else
                {
                    retVal = false;
                }
            }
            else
            {
                if(head.Val == val)
                {
                    var temp = head;
                    tail.next = head.prev;
                    head = head.prev;
                    head = null;
                    size--;
                    retVal = true;
                }
                else
                {
                    var temp = head.next;

                    while(temp != head && temp.Val != val)
                    {
                        temp = temp.next;
                    }

                    if (temp.Val == val)
                    {
                        temp.prev.next = temp.next;
                        temp.next.prev = temp.prev;
                        size--;
                        retVal = true;
                    }
                }
            }

            return retVal;
        }

        public override string ToString()
        {
            if(head == null && tail == null)
            {
                return "";
            }

            if(head == tail)
            {
                return head.Val.ToString();
            }
            var retVal  = "";
            var temp = head;
            while(temp != tail)
            {
                retVal += ' ' + temp.Val.ToString();
                temp = temp.next;
            }
            retVal += ' ' + tail.Val.ToString();

            return retVal;
        }



        public class Node
        {
            public int Val { get; set; }

            public Node prev;

            public Node next;

            public Node(int val)
            {
                this.Val = val;
            }
        }

    }
}
