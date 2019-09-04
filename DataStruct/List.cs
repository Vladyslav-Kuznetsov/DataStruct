using System;

namespace DataStruct
{
    public class List
    {
        private object[] _list;
        private int _index;
        private int _capacity = 4;
        public int Count { get { return _index; } }

        public List(int capacity)
        {
            _capacity = capacity;
            _list = new object[_capacity];
        }
        public List()
        {
            InitArray();
        }

        public void Add(object obj)
        {
            if (_index == _capacity)
            {
                _capacity *= 2;
                Resize();
            }
            _list[_index] = obj;
            _index++;

        }

        public void Resize()
        {
            object[] tempArray = _list;
            _list = new object[_capacity];

            if (tempArray != null)
            {
                for (int i = 0; i < tempArray.Length; i++)
                {
                    _list[i] = tempArray[i];
                }
            }
        }

        private void InitArray()
        {
            _list = new object[_capacity];
        }

        public void Insert(int index, object obj)
        {
            if (index < 0 || index >= _index)
            {
                throw new IndexOutOfRangeException($"Index: {index}, Size: {_index}");
            }

            Resize();

            for (var i = _index; i > index; i--)
                _list[i] = _list[i - 1];

            _list[index] = obj;
            _index++;
        }

        public void Remove(object obj)
        {
            int index = Array.IndexOf(_list, obj, 0, _index);

            if (index < 0)
            {
                return;
            }

            for (int i = index; i < _index - 1; i++)
            {
                _list[i] = _list[i + 1];
            }

            _index--;

        }

        //public void RemoveAt(int index)
        //{

        //}

        public void Clear()
        {
            if (_index > 0)
            {
                Array.Clear(_list, 0, _index);
                _index = 0;
            }
        }

        public bool Contains(object obj)
        {
            for (int i = 0; i < _index; i++)
            {
                if (obj.Equals(_list[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(object obj)
        {
            for (int i = 0; i < _index; i++)
            {
                if (obj.Equals(_list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public object[] ToArray()
        {
            object[] result = new object[Count];

            for (int i = 0; i < Count; i++)
            {
                result[i] = _list[i];
            }

            return result;
        }

        public object this[int key]
        {
            get
            {
                return _list[key];
            }
        }

        public void Reverse()
        {
            for (int i = 0; i < _index / 2; i++)
            {
                object temp = _list[i];
                _list[i] = _list[_index - 1 - i];
                _list[_index - 1 - i] = temp;
            }
        }

    }
}
