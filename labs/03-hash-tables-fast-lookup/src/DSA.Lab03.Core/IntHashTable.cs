using System;
using System.Collections.Generic;

namespace DSA.Lab03
{
    public sealed class IntHashTable<TValue>
    {
        private readonly List<Entry<TValue>>[] _buckets;
        private int _count;

        public IntHashTable(int bucketCount)
        {
            if (bucketCount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(bucketCount));
            }

            _buckets = new List<Entry<TValue>>[bucketCount];
            for (int i = 0; i < _buckets.Length; ++i)
            {
                _buckets[i] = new List<Entry<TValue>>();
            }
        }

        public int Count => _count;
        public int BucketCount => _buckets.Length;

        public void Set(int key, TValue value)
        {
            // TODO: search only the correct bucket, replace or append.

            int bucketIndex = GetBucketIndex(key);
            
            for (int i = 0; i < _buckets[bucketIndex].Count; i++)
            {
                if (_buckets[bucketIndex][i].Key != key) continue;
                    
                _buckets[bucketIndex][i] = new Entry<TValue>(key, value);
                return;
            }
            
            _buckets[bucketIndex].Add(new Entry<TValue>(key, value));

            _count++;
        }

        public bool TryGetValue(int key, out TValue value)
        {
            // TODO: search only the correct bucket.
            value = default!;
            
            int bucketIndex = GetBucketIndex(key);

            for (int i = 0; i < _buckets[bucketIndex].Count; i++)
            {
                if (_buckets[bucketIndex][i].Key == key)
                {
                    if (_buckets[bucketIndex][i].Value != null)
                    {
                        value = _buckets[bucketIndex][i].Value;
                        return true;
                    }
                }
            }
            
            return false;
        }

        public bool ContainsKey(int key)
        {
            // TODO: reuse the lookup behavior if useful.
            
            int bucketIndex = GetBucketIndex(key);

            for (int i = 0; i < _buckets[bucketIndex].Count; i++)
            {
                if (_buckets[bucketIndex][i].Key == key)
                    return true;
            }
            
            return false;
        }

        private int GetBucketIndex(int key)
        {
            if (key < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(key), "This learning implementation uses non-negative integer keys.");
            }

            return key % _buckets.Length;
        }
    }
}
