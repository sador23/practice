using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Design_Patterns
{
    public class Employee : Person
    {
        public Employee(string name) : base(name)
        {
            this.salary = 1000;
        }
    }
}
