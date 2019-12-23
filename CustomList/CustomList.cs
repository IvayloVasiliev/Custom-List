using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        private const int initialCapacity = 2;

        private T[] array;

        public CustomList()
        {
            array = new T[initialCapacity];
            Count = 0;
        }

        public int Count { get; private set; }
        public T this[int number]
        {
            get
            {
                // This is invoked when accessing Layout with the [ ].
                if (number >= 0 && number < Count)
                {
                    return array[number];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                // This is invoked when assigning to Layout with the [ ].
                if (number >= 0 && number < Count)
                {
                    array[number] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void Add(T item)
        {
            if (Count == array.Length)
            {
                Resize();
            }

            array[Count++] = item;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(item))
                {
                    array[i] = default(T);
                    Count--;
                    Shrink(i);
                }
            }
        }

        private void Shrink(int index)
        {
            for (int i = index; i < Count; i++)
            {
                array[i] = array[i +1];
            }
        }

      
        private void Resize()
        {
            T[] newArray = new T[array.Length * 2];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;

        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];
            }
        }
    }   
}
