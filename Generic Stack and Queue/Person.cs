using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack_and_Queue
{
    public abstract class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int id, string name, int age) 
        {
            Id = id;
            Name = name;
            Age = age;
        }


        public int CalculateSUprMonth()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"Id: {Id} - Name: {Name} - Age: {Age}";
        }
    }
}
