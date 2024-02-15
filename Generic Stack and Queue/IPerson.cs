using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack_and_Queue
{
    public interface IPerson
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        int CalculateSUprMonth();
    }
}
