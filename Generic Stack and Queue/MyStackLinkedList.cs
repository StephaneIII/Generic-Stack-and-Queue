using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack_and_Queue
{
    public class MyStackLinkedList<T> : IMyStack<T>
    {
        LinkedList<T> linkedList;
        int size = 0;

        public MyStackLinkedList()
        {
            linkedList = new LinkedList<T>();
        }
        public T Peek()
        {
            return linkedList.First.Value;
        }

        public T Pop()
        {
            T element = linkedList.First.Value;
            linkedList.RemoveFirst();
            return element;
        }

        public void Push(T element)
        {
            linkedList.AddFirst(element);
        }
    }
}
