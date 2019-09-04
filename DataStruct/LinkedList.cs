using System;

namespace DataStruct
{
    public class LinkedList
    {
        public Node First { get; private set; }
        public Node Last { get; private set; }
        public int Count { get; private set; }

        public void Add(object obj)
        {
            Node node = new Node(obj);

            if (First == null)
            {
                First = node;
            }
            else
            {
                Last.Next = node;
            }

            Last = node;
            Count++;
        }

        public void AddFirst(object obj)
        {
            Node node = new Node(obj);
            node.Next = First;
            First = node;

            if (Count == 0)
            {
                Last = node;
            }

            Count++;
        }

        public bool Remove(object obj)
        {
            Node current = First;
            Node previous = null;

            while (current != null)
            {
                if (current.Data.Equals(obj))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            Last = previous;
                        }
                    }
                    else
                    {
                        First = First.Next;

                        if (First == null)
                        {
                            Last = null;
                        }

                    }
                    Count--;

                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void Clear()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public void Insert(Node node, object obj)
        {

            Node current = First;
            Node newNode = new Node(obj);

            while (current != null)
            {
                if(current.Data.Equals(node.Data))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    Count++;
                }

                current = current.Next;
            }
        }

        public bool Contains(object obj)
        {
            Node current = First;

            while (current != null)
            {
                if (current.Data.Equals(obj))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public object[] ToArray()
        {
            object[] result = new object[Count];
            Node current = First;

            for(int i = 0; i < Count;i++)
            {
                result[i] = current.Data;
                current = current.Next;
            }

            return result;
        }
    }

    public class Node
    {
        public Node Next { get; set; }
        public object Data { get; set; }

        public Node(object data)
        {
            Data = data;
        }
    }
}
