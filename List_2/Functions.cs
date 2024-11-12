using System;

namespace List_2
{
    class Node
    {
        public int Value;
        public Node Next;
        public Node Prev;

        public Node(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }

    class MyLinkedList
    {
        private Node head;
        private Node tail;

        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }

        public void Chop_et()
        {
            Node a = head;
            while (a != null)
            {
                Console.Write(a.Value + " ");
                a = a.Next;
            }

            Console.WriteLine("null");
        }

        public void Alishtirish()
        {
            if (head == null || head.Next == null)
            {
                return;
            }

            Node first = head;
            head = head.Next;

            head.Prev = null;

            tail.Next = first;
            first.Prev = tail;
            first.Next = null;
            tail = first;
        }       
        
            public void Remove(int maxsusson)
            {
                Node a = head;
                while (a != null)
                {
                    if (a.Value == maxsusson && a.Next != null && a.Next.Value != maxsusson)
                    {
                        Node remove = a.Next;
                        a.Next = remove.Next;
                        if (remove.Next != null)
                        {
                            remove.Next.Prev = a;
                        }
                        remove.Next = null;
                        remove.Prev = null;
                    }
                    a = a.Next;
                }
            }
    }
    
}