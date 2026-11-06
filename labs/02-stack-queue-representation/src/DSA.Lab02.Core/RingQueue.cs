using System;

namespace DSA.Lab02
{
    public sealed class RingQueue<T>
    {
        private readonly T[] _items;
        private int _head;
        private int _tail;
        private int _count;

        public RingQueue(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            _items = new T[capacity];
        }

        public int Count => _count;
        public int Capacity => _items.Length;

        public void Enqueue(T item)
        {
            // TODO: write at tail, advance tail with wrap-around, update count.
            
            if(_count >= _items.Length)
                throw new InvalidOperationException("Queue is full");
            
            _items[_tail] = item;
            _tail = (_tail + 1) % _items.Length;

            if(_count < _items.Length)
                _count++;
        }

        public T Peek()
        {
            // TODO: return the item at head without removing it.
            
            if (_count == 0)
                throw new InvalidOperationException("Queue is empty");
            
            return _items[_head];
        }

        public T Dequeue()
        {
            // TODO: read/clear at head, advance head with wrap-around, update count.

            if (_count == 0)
                throw new InvalidOperationException("Queue is empty");
            
            T result = _items[_head];
            _items[_head] = default;
            _head = (_head + 1) % _items.Length;
            _count--;
            
            return result;
        }
    }
}
