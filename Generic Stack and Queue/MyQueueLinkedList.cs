using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack_and_Queue
{
    public class MyQueueLinkedList<T> : IMyQueue<T>
    {
        LinkedList<T> linkedList;
        int size = 0;

        public MyQueueLinkedList()
        {
            linkedList = new LinkedList<T>();
        }

        public T Dequeue()
        {
            T temp = linkedList.Last();
            linkedList.RemoveLast();
            return temp;
        }

        public void Enqueue(T item)
        {
            linkedList.AddLast(item);
        }
    }
}
