using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack_and_Queue
{
    public class MyStackIsEmptyException : Exception
    {
        public MyStackIsEmptyException(String message) : base(message)
        {

        }
    }
}
