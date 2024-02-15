using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack_and_Queue
{
    public class StudentOut: Person
    {

        public StudentOut(int id, string name, int age) : base(id, name, age)
        {
        }

        public int CalculateSUprMonth()
        {
            if (Age < 18)
                return 4055;
            else
                return 6321;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {CalculateSUprMonth()}";
        }
    }
}
