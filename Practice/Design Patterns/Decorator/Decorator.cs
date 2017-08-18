using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Design_Patterns.Decorator
{
    public class Decorator : Person
    {
        protected Person person;

        public Decorator(string name, Person person) : base(name)
        {
            this.person = person;
            this.salary = GetSalary();
        }
        
    }
}
