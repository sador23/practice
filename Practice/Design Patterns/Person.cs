using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Design_Patterns
{
    public class Person
    {
        public string name;
        public int id;
        public int salary;
        private static int id_counter;

        public Person(string name)
        {
            id = id_counter++;
            this.name = name;
        }

        public virtual int GetSalary()
        {
            return salary;
        }

        public override string ToString()
        {
            return this.name + " is a " + this.GetType().Name + " and earns " + this.salary;
        }
    }
}
