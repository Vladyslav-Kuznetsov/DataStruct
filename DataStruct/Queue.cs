namespace DataStruct
{
    public class Queue
    {
        private DoublyLinkedList _linkedList = new DoublyLinkedList();
        public int Count { get { return _linkedList.Count; } }

        public void Enqueue(object obj)
        {
            _linkedList.Add(obj);
        }

        public object Dequeue()
        {
            object result = _linkedList.First.Data;
            _linkedList.RemoveFirst();

            return result;
        }

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
            return _linkedList.First.Data;
        }

        public object[] ToArray()
        {
            return _linkedList.ToArray();
        }
    }
}
