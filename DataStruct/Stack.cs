namespace DataStruct
{
    public class Stack
    {
        private DoublyLinkedList _linkedList = new DoublyLinkedList();

        public int Count { get { return _linkedList.Count; } }

        public void Clear()
        {
            _linkedList.Clear();
        }

        public bool Contains(object obj)
        {
            return _linkedList.Contains(obj);
        }

        public object Peek()
        {
            return _linkedList.Last.Data;
        }

        public object[] ToArray()
        {
            return _linkedList.ToArray();
        }

        public void Push(object obj)
        {
            _linkedList.Add(obj);
        }

        public object Pop()
        {
            object result = _linkedList.Last.Data;
            _linkedList.RemoveLast();

            return result;
        }

    }
}
