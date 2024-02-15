using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack_and_Queue
{
    public class MyStackArray<T> : IMyStack<T>
    {
        T[] array;

        public MyStackArray(int size)
        {
            array = new T[size];
        }

        public T Peek()
        {
            return array[0];
        }

        public T Pop()
        {
            T element = array[0];
            array = array.Skip(1).ToArray();
            return element;
        }

        public void Push(T element)
        {
            List<T> temp = array.ToList();
            temp.Add(element);
            array = temp.ToArray();
        }
    }
}
