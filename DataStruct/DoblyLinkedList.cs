using System;

namespace DataStruct
{
    public class DoublyLinkedList
    {
        public DoublyNode First { get; private set; }
        public DoublyNode Last { get; private set; }
        public int Count { get; private set; }

        public void Add(object obj)
        {
            DoublyNode node = new DoublyNode(obj);

            if (First == null)
            {
                First = node;
            }
            else
            {
                Last.Next = node;
                node.Previous = Last;
            }

            Last = node;
            Count++;
        }
        public void AddFirst(object obj)
        {
            DoublyNode node = new DoublyNode(obj);

            node.Next = First;
            First.Previous = node;
            First = node;

            if (Count == 0)
            {
                Last = node;
            }

            Count++;
        }
        public void Remove(object obj)
        {
            DoublyNode current = First;

            while (current != null)
            {
                if (current.Data.Equals(obj))
                {
                    break;
                }
                current = current.Next;
            }

            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    Last = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    First = current.Next;
                }

                Count--;
            }
        }
        public void RemoveFirst()
        {
            First = First.Next;
            First.Previous = null;
            Count--;
        }
        public void RemoveLast()
        {
            Last = Last.Previous;
            Last.Next = null;
            Count--;
        }
        public bool Contains(object obj)
        {
            DoublyNode current = First;

            while(current != null)
            {
                if(current.Data.Equals(obj))
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
            DoublyNode current = First;

            for (int i = 0; i < Count; i++)
            {
                result[i] = current.Data;
                current = current.Next;
            }
            return result;
        }
        public void Clear()
        {
            First = null;
            Last = null;
            Count = 0;
        }
    }

    public class DoublyNode
    {
        public DoublyNode Next { get; set; }
        public DoublyNode Previous { get; set; }
        public object Data { get; set; }

        public DoublyNode(object data)
        {
            Data = data;
        }
    }
}
