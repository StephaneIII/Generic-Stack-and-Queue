using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack_and_Queue
{
    public class MyQueueArray<T> : IMyQueue<T>
    {
        T[] array;

        public MyQueueArray(int size)
        {
            array = new T[size];
        }

        public T Dequeue()
        {
            T temp = array.Last();
            array.SkipLast(1);
            return temp;
        }

        public void Enqueue(T item)
        {
            List<T> temp = array.ToList();
            temp.Insert(array.Length + 1, item);
            array = temp.ToArray();
        }
    }
}
