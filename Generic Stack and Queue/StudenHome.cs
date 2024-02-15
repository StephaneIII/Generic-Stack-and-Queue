using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack_and_Queue
{
    public class StudenHome : Person
    {
        public int ParentIncome { get; set; }

        public StudenHome(int parentIncome, int id, string name, int age): base(id, name, age)
        {
            ParentIncome = parentIncome;
        }

        public int CalculateSUprMonth()
        {
            if (Age < 20)
                return 3143;
            else
            {
                if (ParentIncome > 60000)
                    return 1013;
                else
                    return 2725;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} { CalculateSUprMonth() }";
        }
    }
}
