using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack_and_Queue
{
    public class MyStackFullException : Exception
    {
        public MyStackFullException(string message) : base(message)
        {
        }
    }
}
