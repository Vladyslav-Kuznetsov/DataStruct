using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStruct
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; }
        public int Count { get; private set; }

        public void Add(T obj)
        {
            Node<T> node = new Node<T>(obj);

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

        public void AddFirst(T obj)
        {
            Node<T> node = new Node<T>(obj);
            node.Next = First;
            First = node;

            if (Count == 0)
            {
                Last = node;
            }

            Count++;
        }

        public bool Remove(T obj)
        {
            Node<T> current = First;
            Node<T> previous = null;

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

        public void Insert(Node<T> node, T obj)
        {

            Node<T> current = First;
            Node<T> newNode = new Node<T>(obj);

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

        public bool Contains(T obj)
        {
            Node<T> current = First;

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

        public T[] ToArray()
        {
            T[] result = new T[Count];
            Node<T> current = First;

            for(int i = 0; i < Count;i++)
            {
                result[i] = current.Data;
                current = current.Next;
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (Node<T> current = First; current != null;current = current.Next)
            {
                yield return current.Data;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }
}
